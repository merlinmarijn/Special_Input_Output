namespace Voice_Recognition_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrentWordBox = new System.Windows.Forms.RichTextBox();
            this.DetectedWordBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SkipWordButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.AttemptBox = new System.Windows.Forms.RichTextBox();
            this.WordListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SynAttempts = new System.Windows.Forms.RichTextBox();
            this.SynButton = new System.Windows.Forms.Button();
            this.GameIcon = new System.Windows.Forms.PictureBox();
            this.EnableSkipWord = new System.Windows.Forms.CheckBox();
            this.EnableHearWord = new System.Windows.Forms.CheckBox();
            this.EnableListBox = new System.Windows.Forms.CheckBox();
            this.EnableCustomFile = new System.Windows.Forms.CheckBox();
            this.RestartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentWordBox
            // 
            this.CurrentWordBox.Enabled = false;
            this.CurrentWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWordBox.Location = new System.Drawing.Point(12, 13);
            this.CurrentWordBox.Multiline = false;
            this.CurrentWordBox.Name = "CurrentWordBox";
            this.CurrentWordBox.ReadOnly = true;
            this.CurrentWordBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CurrentWordBox.Size = new System.Drawing.Size(340, 115);
            this.CurrentWordBox.TabIndex = 0;
            this.CurrentWordBox.Text = "Computer side";
            this.CurrentWordBox.Visible = false;
            // 
            // DetectedWordBox
            // 
            this.DetectedWordBox.Enabled = false;
            this.DetectedWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectedWordBox.Location = new System.Drawing.Point(776, 12);
            this.DetectedWordBox.Multiline = false;
            this.DetectedWordBox.Name = "DetectedWordBox";
            this.DetectedWordBox.ReadOnly = true;
            this.DetectedWordBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DetectedWordBox.Size = new System.Drawing.Size(340, 115);
            this.DetectedWordBox.TabIndex = 1;
            this.DetectedWordBox.Text = "...Player Input...";
            this.DetectedWordBox.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(477, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 111);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(509, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SkipWordButton
            // 
            this.SkipWordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SkipWordButton.Location = new System.Drawing.Point(604, 12);
            this.SkipWordButton.Name = "SkipWordButton";
            this.SkipWordButton.Size = new System.Drawing.Size(129, 61);
            this.SkipWordButton.TabIndex = 4;
            this.SkipWordButton.Text = "Skip Word";
            this.SkipWordButton.UseVisualStyleBackColor = false;
            this.SkipWordButton.Visible = false;
            this.SkipWordButton.Click += new System.EventHandler(this.SkipWordButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(776, 158);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(340, 34);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 158);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(340, 34);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 100;
            this.progressBar2.Visible = false;
            // 
            // AttemptBox
            // 
            this.AttemptBox.Enabled = false;
            this.AttemptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptBox.Location = new System.Drawing.Point(534, 12);
            this.AttemptBox.Multiline = false;
            this.AttemptBox.Name = "AttemptBox";
            this.AttemptBox.ReadOnly = true;
            this.AttemptBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AttemptBox.Size = new System.Drawing.Size(64, 61);
            this.AttemptBox.TabIndex = 7;
            this.AttemptBox.Text = "5";
            this.AttemptBox.Visible = false;
            // 
            // WordListBox
            // 
            this.WordListBox.FormattingEnabled = true;
            this.WordListBox.Location = new System.Drawing.Point(12, 208);
            this.WordListBox.Name = "WordListBox";
            this.WordListBox.Size = new System.Drawing.Size(143, 355);
            this.WordListBox.TabIndex = 8;
            this.WordListBox.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OpenFileButton.Location = new System.Drawing.Point(12, 580);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(143, 61);
            this.OpenFileButton.TabIndex = 9;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Visible = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SynAttempts
            // 
            this.SynAttempts.Enabled = false;
            this.SynAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SynAttempts.Location = new System.Drawing.Point(534, 79);
            this.SynAttempts.Multiline = false;
            this.SynAttempts.Name = "SynAttempts";
            this.SynAttempts.ReadOnly = true;
            this.SynAttempts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SynAttempts.Size = new System.Drawing.Size(64, 61);
            this.SynAttempts.TabIndex = 11;
            this.SynAttempts.Text = "3";
            this.SynAttempts.Visible = false;
            // 
            // SynButton
            // 
            this.SynButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SynButton.Location = new System.Drawing.Point(604, 79);
            this.SynButton.Name = "SynButton";
            this.SynButton.Size = new System.Drawing.Size(129, 61);
            this.SynButton.TabIndex = 10;
            this.SynButton.Text = "Hear Word";
            this.SynButton.UseVisualStyleBackColor = false;
            this.SynButton.Visible = false;
            this.SynButton.Click += new System.EventHandler(this.SynButton_Click);
            // 
            // GameIcon
            // 
            this.GameIcon.BackColor = System.Drawing.Color.Transparent;
            this.GameIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameIcon.BackgroundImage")));
            this.GameIcon.Location = new System.Drawing.Point(956, 478);
            this.GameIcon.Name = "GameIcon";
            this.GameIcon.Size = new System.Drawing.Size(160, 160);
            this.GameIcon.TabIndex = 12;
            this.GameIcon.TabStop = false;
            this.GameIcon.Visible = false;
            // 
            // EnableSkipWord
            // 
            this.EnableSkipWord.AutoSize = true;
            this.EnableSkipWord.Location = new System.Drawing.Point(534, 372);
            this.EnableSkipWord.Name = "EnableSkipWord";
            this.EnableSkipWord.Size = new System.Drawing.Size(109, 17);
            this.EnableSkipWord.TabIndex = 13;
            this.EnableSkipWord.Text = "Enable Skip word";
            this.EnableSkipWord.UseVisualStyleBackColor = true;
            // 
            // EnableHearWord
            // 
            this.EnableHearWord.AutoSize = true;
            this.EnableHearWord.Location = new System.Drawing.Point(534, 416);
            this.EnableHearWord.Name = "EnableHearWord";
            this.EnableHearWord.Size = new System.Drawing.Size(114, 17);
            this.EnableHearWord.TabIndex = 14;
            this.EnableHearWord.Text = "Enable Hear Word";
            this.EnableHearWord.UseVisualStyleBackColor = true;
            // 
            // EnableListBox
            // 
            this.EnableListBox.AutoSize = true;
            this.EnableListBox.Location = new System.Drawing.Point(534, 462);
            this.EnableListBox.Name = "EnableListBox";
            this.EnableListBox.Size = new System.Drawing.Size(162, 17);
            this.EnableListBox.TabIndex = 15;
            this.EnableListBox.Text = "Enable Manual Word Choice";
            this.EnableListBox.UseVisualStyleBackColor = true;
            // 
            // EnableCustomFile
            // 
            this.EnableCustomFile.AutoSize = true;
            this.EnableCustomFile.Location = new System.Drawing.Point(534, 513);
            this.EnableCustomFile.Name = "EnableCustomFile";
            this.EnableCustomFile.Size = new System.Drawing.Size(141, 17);
            this.EnableCustomFile.TabIndex = 16;
            this.EnableCustomFile.Text = "Enable Manual Word list";
            this.EnableCustomFile.UseVisualStyleBackColor = true;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RestartButton.Location = new System.Drawing.Point(875, 618);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 17;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 650);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.EnableCustomFile);
            this.Controls.Add(this.EnableListBox);
            this.Controls.Add(this.EnableHearWord);
            this.Controls.Add(this.EnableSkipWord);
            this.Controls.Add(this.GameIcon);
            this.Controls.Add(this.SynAttempts);
            this.Controls.Add(this.SynButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.WordListBox);
            this.Controls.Add(this.AttemptBox);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SkipWordButton);
            this.Controls.Add(this.DetectedWordBox);
            this.Controls.Add(this.CurrentWordBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CurrentWordBox;
        private System.Windows.Forms.RichTextBox DetectedWordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SkipWordButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.RichTextBox AttemptBox;
        private System.Windows.Forms.ListBox WordListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.RichTextBox SynAttempts;
        private System.Windows.Forms.Button SynButton;
        private System.Windows.Forms.PictureBox GameIcon;
        private System.Windows.Forms.CheckBox EnableSkipWord;
        private System.Windows.Forms.CheckBox EnableHearWord;
        private System.Windows.Forms.CheckBox EnableListBox;
        private System.Windows.Forms.CheckBox EnableCustomFile;
        private System.Windows.Forms.Button RestartButton;
    }
}

