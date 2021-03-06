﻿using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;

namespace Voice_Recognition_Game
{
    //Button 1 = Start Button
    //Button 2 = Exit Button
    //Button 3 = Skip Button
    //Progressbar 1 = Player Health
    //Progressbar 2 = PC Health
    //CurrentWordBox = the word currently assigned to speak out
    //DetectedWordBox = the box where it displays what it hears from the player
    public partial class Form1 : Form
    {
        //set Language
        CultureInfo cInfo = new CultureInfo("en-us", true);
        //Instantiate SpeechRecognitionEngine as recEngine
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer Speech = new SpeechSynthesizer();
        //List of all the words in it stored so it can be pulled when needed
        string[] WordList;
        Random rand = new Random();
        int attempts = 5;
        int synattempts = 3;
        bool Listening = false;
        OpenFileDialog openfiledialog = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.CenterToScreen();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Instantia a SpeechRecognitionEngine with all components
            recEngine.LoadGrammarAsync(new DictationGrammar());
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
            WordListBox.SelectedValueChanged += WordListBox_SelectedValueChanged;

            loadWords();
            AttemptBox.Text = attempts.ToString();
            SynAttempts.Text = synattempts.ToString();
        }

        private void WordListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            var confirmResult = 
            MessageBox.Show("Are you Sure you want to change current active word? \nYou will take 10 damage if you do","Skip word", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                CurrentWordBox.Text = listbox.SelectedItem.ToString();
                takeDamage(10);
            }
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (Listening)
            {
                DetectedWordBox.Text = e.Result.Text.ToLower();
                //if Detected word is the same as current given word do damage and get next word
                if (e.Result.Text == CurrentWordBox.Text)
                {
                    doDamage(20);
                    if (progressBar1.Value <= 60)
                    {
                        progressBar1.Value += 40;
                        attempts = 5;
                        loadWord();
                    }
                    else { progressBar1.Value = 100; loadWord(); attempts = 5; }
                }
                else
                {
                    //If detected word isnt same as current given word -1 chance if 0 chances take damage
                    attempts -= 1;
                    AttemptBox.Text = attempts.ToString();
                    if (attempts <= 0)
                    {
                        attempts = 5;
                        AttemptBox.Text = attempts.ToString();
                        takeDamage(20);
                        loadWord();
                    }
                }
                if (DetectedWordBox.Text == "exit game")
                {
                    Application.Exit();
                }
            }
        }


        //On startup load default wordlist
        private void loadWords()
        {
            using (StreamReader sr = new StreamReader("Words.txt"))
            {
                string line = sr.ReadToEnd();
                WordList = line.Split('\n');
            }
            foreach(string item in WordList)
            {
                WordListBox.Items.Add(item);
            }
        }
        //Get random word from wordlist and load in current word
        private void loadWord()
        {
            CurrentWordBox.Text = WordList[rand.Next(0, WordList.Length - 1)];
        }

        //Start button
        private void button1_Click(object sender, EventArgs e)
        {
            loadWord();
            button1.Visible = false;
            button2.Visible = true;
            CurrentWordBox.Visible = true;
            DetectedWordBox.Visible = true;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            AttemptBox.Visible = true;
            RestartButton.Visible = true;
            if (EnableSkipWord.Checked) {SkipWordButton.Visible = true;}
            if (EnableHearWord.Checked) {SynButton.Visible = true; SynAttempts.Visible = true;}
            if (EnableListBox.Checked) {WordListBox.Visible = true;}
            if (EnableCustomFile.Checked) {OpenFileButton.Visible = true;}
            GameIcon.Visible = true;
            EnableSkipWord.Visible = false;
            EnableHearWord.Visible = false;
            EnableListBox.Visible = false;
            EnableCustomFile.Visible = false;
            Listening = true;
        }

        //Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Skip Button
        private void SkipWordButton_Click(object sender, EventArgs e)
        {
            attempts -= 1;
            if (attempts <= 0)
            {
                attempts = 5;
                takeDamage(20);
            }
            AttemptBox.Text = attempts.ToString();
            loadWord();
        }
        //take damage (input)
        private void takeDamage(int damage)
        {
            if ((progressBar1.Value -= damage) > 0)
            {
                progressBar1.Value -= damage;
            } else { Restart(); }
        }
        //do damage (input)
        private void doDamage(int damage)
        {
            if ((progressBar2.Value -= damage)>0)
            {
                progressBar2.Value -= damage;
            } else { Restart(); }
        }

        private void Restart()
        {
            Application.Restart();
        }

        //Manually open file with own word list
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            //add filter so it only shows VRN (custom) files
            openfiledialog.Filter = "vrn files (*.vrn)|*.vrn";
            //open folder window
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                //var filepath = openfiledialog.FileName;
                var filestream = openfiledialog.OpenFile();

                using(StreamReader reader = new StreamReader(filestream))
                {
                    var filecontent = reader.ReadToEnd();
                    WordList = filecontent.Split('\n');
                    WordListBox.Items.Clear();
                    foreach (string item in WordList)
                    {
                        WordListBox.Items.Add(item);
                    }
                    loadWord();
                }
            }
        }

        //Hear word button
        private void SynButton_Click(object sender, EventArgs e)
        {
            //if you have voice chances remove 1 chance and speak word
            if (synattempts > 0)
            {
                synattempts -= 1;
                SynAttempts.Text = synattempts.ToString();
                Speech.Speak(CurrentWordBox.Text);
            }
            //if you used to many voice syn attempts take damage
            if (synattempts <= 0)
            {
                takeDamage(5);
                synattempts = 3;
                SynAttempts.Text = synattempts.ToString();
            }
        }

        //restart program button with confirm window
        private void RestartButton_Click(object sender, EventArgs e)
        {
            var confirmResult =
            MessageBox.Show("You are about to restart the program, \nAre you sure you want to?",
            "Restart Program?", MessageBoxButtons.YesNo); if (confirmResult == DialogResult.Yes)
            {
                Restart();
            }
        }
    }
}
