namespace Rock_Paper_Scissors_.net
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            CPU_PIC = new PictureBox();
            PLAYER_PIC = new PictureBox();
            IblCPUchoice = new Label();
            IblPlayerchoice = new Label();
            IblPlayerresult = new Label();
            IblCPUresult = new Label();
            HistoryDB = new Button();
            pause = new Button();
            play = new Button();
            playername = new GroupBox();
            username1 = new TextBox();
            username = new Label();
            button1 = new Button();
            quitbtn = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).BeginInit();
            playername.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRock.Location = new Point(66, 369);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(136, 43);
            btnRock.TabIndex = 0;
            btnRock.Tag = "R";
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += MakeChoiceEvent;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaper.Location = new Point(345, 369);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(139, 43);
            btnPaper.TabIndex = 1;
            btnPaper.Tag = "P";
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += MakeChoiceEvent;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScissors.Location = new Point(623, 369);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(136, 43);
            btnScissors.TabIndex = 2;
            btnScissors.Tag = "S";
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += MakeChoiceEvent;
            // 
            // CPU_PIC
            // 
            CPU_PIC.Location = new Point(367, 50);
            CPU_PIC.Name = "CPU_PIC";
            CPU_PIC.Size = new Size(100, 100);
            CPU_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            CPU_PIC.TabIndex = 3;
            CPU_PIC.TabStop = false;
            CPU_PIC.Click += CPU_PIC_Click;
            // 
            // PLAYER_PIC
            // 
            PLAYER_PIC.Location = new Point(367, 210);
            PLAYER_PIC.Name = "PLAYER_PIC";
            PLAYER_PIC.Size = new Size(100, 100);
            PLAYER_PIC.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYER_PIC.TabIndex = 4;
            PLAYER_PIC.TabStop = false;
            // 
            // IblCPUchoice
            // 
            IblCPUchoice.AutoSize = true;
            IblCPUchoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblCPUchoice.ForeColor = Color.White;
            IblCPUchoice.Location = new Point(297, 9);
            IblCPUchoice.Name = "IblCPUchoice";
            IblCPUchoice.Size = new Size(170, 28);
            IblCPUchoice.TabIndex = 5;
            IblCPUchoice.Text = "Computer Choice";
            IblCPUchoice.Click += label1_Click;
            // 
            // IblPlayerchoice
            // 
            IblPlayerchoice.AutoSize = true;
            IblPlayerchoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblPlayerchoice.ForeColor = Color.White;
            IblPlayerchoice.Location = new Point(322, 323);
            IblPlayerchoice.Name = "IblPlayerchoice";
            IblPlayerchoice.Size = new Size(139, 28);
            IblPlayerchoice.TabIndex = 6;
            IblPlayerchoice.Text = "           Choice";
            IblPlayerchoice.Click += label1_Click_1;
            // 
            // IblPlayerresult
            // 
            IblPlayerresult.AutoSize = true;
            IblPlayerresult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblPlayerresult.ForeColor = Color.White;
            IblPlayerresult.Location = new Point(165, 169);
            IblPlayerresult.Name = "IblPlayerresult";
            IblPlayerresult.Size = new Size(139, 28);
            IblPlayerresult.TabIndex = 7;
            IblPlayerresult.Text = "            Result";
            // 
            // IblCPUresult
            // 
            IblCPUresult.AutoSize = true;
            IblCPUresult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblCPUresult.ForeColor = Color.White;
            IblCPUresult.Location = new Point(545, 169);
            IblCPUresult.Name = "IblCPUresult";
            IblCPUresult.Size = new Size(164, 28);
            IblCPUresult.TabIndex = 8;
            IblCPUresult.Text = "Computer Result";
            // 
            // HistoryDB
            // 
            HistoryDB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HistoryDB.Location = new Point(620, 15);
            HistoryDB.Name = "HistoryDB";
            HistoryDB.Size = new Size(139, 43);
            HistoryDB.TabIndex = 9;
            HistoryDB.Tag = "P";
            HistoryDB.Text = "History";
            HistoryDB.UseVisualStyleBackColor = true;
            HistoryDB.Click += ViewHistory;
            // 
            // pause
            // 
            pause.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pause.Location = new Point(623, 308);
            pause.Name = "pause";
            pause.Size = new Size(136, 43);
            pause.TabIndex = 10;
            pause.Text = "Stop";
            pause.UseVisualStyleBackColor = true;
            pause.Click += pause_button;
            // 
            // play
            // 
            play.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            play.Location = new Point(66, 308);
            play.Name = "play";
            play.Size = new Size(136, 43);
            play.TabIndex = 11;
            play.Text = "Play";
            play.UseVisualStyleBackColor = true;
            play.Click += play_button;
            // 
            // playername
            // 
            playername.Controls.Add(username1);
            playername.Controls.Add(username);
            playername.Controls.Add(button1);
            playername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            playername.ForeColor = SystemColors.HighlightText;
            playername.Location = new Point(211, 97);
            playername.Name = "playername";
            playername.Size = new Size(429, 182);
            playername.TabIndex = 12;
            playername.TabStop = false;
            playername.Text = "Player Name";
            // 
            // username1
            // 
            username1.Font = new Font("Segoe UI", 10F);
            username1.Location = new Point(72, 77);
            username1.Name = "username1";
            username1.PlaceholderText = "Enter your name";
            username1.Size = new Size(295, 30);
            username1.TabIndex = 2;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            username.Location = new Point(72, 51);
            username.Name = "username";
            username.Size = new Size(67, 23);
            username.TabIndex = 1;
            username.Text = "Name: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(168, 113);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += UName_button;
            // 
            // quitbtn
            // 
            quitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quitbtn.Location = new Point(63, 15);
            quitbtn.Name = "quitbtn";
            quitbtn.Size = new Size(139, 43);
            quitbtn.TabIndex = 13;
            quitbtn.Tag = "P";
            quitbtn.Text = "Quit";
            quitbtn.UseVisualStyleBackColor = true;
            quitbtn.Click += Quit_button;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 397);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "History";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(343, 339);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(31, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(716, 264);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(355, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 0;
            label1.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(quitbtn);
            Controls.Add(playername);
            Controls.Add(play);
            Controls.Add(pause);
            Controls.Add(HistoryDB);
            Controls.Add(IblCPUresult);
            Controls.Add(IblPlayerresult);
            Controls.Add(IblPlayerchoice);
            Controls.Add(IblCPUchoice);
            Controls.Add(PLAYER_PIC);
            Controls.Add(CPU_PIC);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Rock Paper Scissor Game";
            ((System.ComponentModel.ISupportInitialize)CPU_PIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLAYER_PIC).EndInit();
            playername.ResumeLayout(false);
            playername.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label IblCPUchoice;
        private Label IblPlayerchoice;
        private Label IblPlayerresult;
        private Label IblCPUresult;
        private Button HistoryDB;
        private Button pause;
        private Button play;
        private GroupBox playername;
        private Button button1;
        private TextBox username1;
        private Label username;
        private Button quitbtn;
        private GroupBox groupBox1;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
    }
}
