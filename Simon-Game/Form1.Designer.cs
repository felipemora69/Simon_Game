namespace Simon_Game
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
            btn_Yellow = new Button();
            btn_Green = new Button();
            btn_Red = new Button();
            btn_Blue = new Button();
            label1 = new Label();
            btn_NewGame = new Button();
            lbl_Score = new Label();
            lbl_HighScore = new Label();
            lbl_Overall = new Label();
            output_PlayerName = new Label();
            lbl_turn = new Label();
            btn_Start = new Button();
            lbl_ready = new Label();
            lbl_title = new Label();
            lbl_ScoreBoard = new Label();
            user_1 = new Label();
            user_2 = new Label();
            user_3 = new Label();
            lbl_credits = new Label();
            SuspendLayout();
            // 
            // btn_Yellow
            // 
            btn_Yellow.BackColor = Color.Yellow;
            btn_Yellow.Cursor = Cursors.Hand;
            btn_Yellow.ForeColor = SystemColors.ActiveCaptionText;
            btn_Yellow.Location = new Point(484, 390);
            btn_Yellow.Name = "btn_Yellow";
            btn_Yellow.Size = new Size(154, 129);
            btn_Yellow.TabIndex = 2;
            btn_Yellow.UseVisualStyleBackColor = false;
            btn_Yellow.Visible = false;
            btn_Yellow.Click += btn_Yellow_Click_1;
            // 
            // btn_Green
            // 
            btn_Green.BackColor = Color.DarkGreen;
            btn_Green.Cursor = Cursors.Hand;
            btn_Green.ForeColor = SystemColors.ButtonHighlight;
            btn_Green.Location = new Point(484, 260);
            btn_Green.Name = "btn_Green";
            btn_Green.Size = new Size(154, 124);
            btn_Green.TabIndex = 3;
            btn_Green.UseVisualStyleBackColor = false;
            btn_Green.Visible = false;
            btn_Green.Click += btn_Green_Click_1;
            // 
            // btn_Red
            // 
            btn_Red.BackColor = Color.Red;
            btn_Red.Cursor = Cursors.Hand;
            btn_Red.ForeColor = SystemColors.ButtonHighlight;
            btn_Red.Location = new Point(644, 260);
            btn_Red.Name = "btn_Red";
            btn_Red.Size = new Size(154, 124);
            btn_Red.TabIndex = 4;
            btn_Red.UseVisualStyleBackColor = false;
            btn_Red.Visible = false;
            btn_Red.Click += btn_Red_Click_1;
            // 
            // btn_Blue
            // 
            btn_Blue.BackColor = Color.Blue;
            btn_Blue.Cursor = Cursors.Hand;
            btn_Blue.ForeColor = SystemColors.ButtonHighlight;
            btn_Blue.Location = new Point(644, 390);
            btn_Blue.Name = "btn_Blue";
            btn_Blue.Size = new Size(154, 129);
            btn_Blue.TabIndex = 5;
            btn_Blue.UseVisualStyleBackColor = false;
            btn_Blue.Visible = false;
            btn_Blue.Click += btn_Blue_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(532, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 50);
            label1.TabIndex = 6;
            label1.Text = "Simon Game";
            label1.Visible = false;
            // 
            // btn_NewGame
            // 
            btn_NewGame.BackColor = SystemColors.WindowFrame;
            btn_NewGame.ForeColor = SystemColors.ButtonHighlight;
            btn_NewGame.Location = new Point(1089, 549);
            btn_NewGame.Name = "btn_NewGame";
            btn_NewGame.Size = new Size(106, 39);
            btn_NewGame.TabIndex = 7;
            btn_NewGame.Text = "New Game";
            btn_NewGame.UseVisualStyleBackColor = false;
            btn_NewGame.Visible = false;
            btn_NewGame.Click += btn_NewGame_Click;
            // 
            // lbl_Score
            // 
            lbl_Score.AutoSize = true;
            lbl_Score.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Score.ForeColor = SystemColors.ButtonHighlight;
            lbl_Score.Location = new Point(212, 328);
            lbl_Score.Name = "lbl_Score";
            lbl_Score.Size = new Size(0, 21);
            lbl_Score.TabIndex = 8;
            lbl_Score.Visible = false;
            // 
            // lbl_HighScore
            // 
            lbl_HighScore.AutoSize = true;
            lbl_HighScore.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_HighScore.ForeColor = SystemColors.ButtonHighlight;
            lbl_HighScore.Location = new Point(212, 363);
            lbl_HighScore.Name = "lbl_HighScore";
            lbl_HighScore.Size = new Size(0, 21);
            lbl_HighScore.TabIndex = 9;
            lbl_HighScore.Visible = false;
            // 
            // lbl_Overall
            // 
            lbl_Overall.AutoSize = true;
            lbl_Overall.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Overall.ForeColor = SystemColors.ButtonHighlight;
            lbl_Overall.Location = new Point(212, 402);
            lbl_Overall.Name = "lbl_Overall";
            lbl_Overall.Size = new Size(0, 21);
            lbl_Overall.TabIndex = 10;
            lbl_Overall.Visible = false;
            // 
            // output_PlayerName
            // 
            output_PlayerName.AutoSize = true;
            output_PlayerName.BackColor = SystemColors.InactiveCaptionText;
            output_PlayerName.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            output_PlayerName.ForeColor = SystemColors.ButtonHighlight;
            output_PlayerName.Location = new Point(999, 197);
            output_PlayerName.Name = "output_PlayerName";
            output_PlayerName.Size = new Size(0, 18);
            output_PlayerName.TabIndex = 17;
            output_PlayerName.Visible = false;
            // 
            // lbl_turn
            // 
            lbl_turn.AutoSize = true;
            lbl_turn.BackColor = SystemColors.InactiveCaptionText;
            lbl_turn.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_turn.ForeColor = SystemColors.ButtonHighlight;
            lbl_turn.Location = new Point(991, 158);
            lbl_turn.Name = "lbl_turn";
            lbl_turn.Size = new Size(99, 29);
            lbl_turn.TabIndex = 18;
            lbl_turn.Text = "Player";
            lbl_turn.Visible = false;
            // 
            // btn_Start
            // 
            btn_Start.BackColor = SystemColors.WindowFrame;
            btn_Start.Cursor = Cursors.Hand;
            btn_Start.ForeColor = SystemColors.ButtonHighlight;
            btn_Start.Location = new Point(565, 94);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(165, 39);
            btn_Start.TabIndex = 19;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Visible = false;
            btn_Start.Click += btn_Start_Click_1;
            // 
            // lbl_ready
            // 
            lbl_ready.AutoSize = true;
            lbl_ready.BackColor = SystemColors.InactiveCaptionText;
            lbl_ready.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ready.ForeColor = SystemColors.ButtonHighlight;
            lbl_ready.Location = new Point(596, 186);
            lbl_ready.Name = "lbl_ready";
            lbl_ready.Size = new Size(0, 29);
            lbl_ready.TabIndex = 20;
            lbl_ready.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ready.Visible = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.BackColor = SystemColors.ActiveCaptionText;
            lbl_title.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = SystemColors.ButtonHighlight;
            lbl_title.Location = new Point(542, 250);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(0, 46);
            lbl_title.TabIndex = 21;
            lbl_title.Visible = false;
            // 
            // lbl_ScoreBoard
            // 
            lbl_ScoreBoard.AutoSize = true;
            lbl_ScoreBoard.BackColor = SystemColors.InactiveCaptionText;
            lbl_ScoreBoard.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ScoreBoard.ForeColor = SystemColors.ButtonHighlight;
            lbl_ScoreBoard.Location = new Point(76, 84);
            lbl_ScoreBoard.Name = "lbl_ScoreBoard";
            lbl_ScoreBoard.Size = new Size(110, 29);
            lbl_ScoreBoard.TabIndex = 22;
            lbl_ScoreBoard.Text = "Scores :";
            lbl_ScoreBoard.Visible = false;
            // 
            // user_1
            // 
            user_1.AutoSize = true;
            user_1.BackColor = SystemColors.InactiveCaptionText;
            user_1.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_1.ForeColor = SystemColors.ButtonHighlight;
            user_1.Location = new Point(74, 127);
            user_1.Name = "user_1";
            user_1.Size = new Size(166, 23);
            user_1.TabIndex = 23;
            user_1.Text = "systemdefault";
            user_1.Visible = false;
            // 
            // user_2
            // 
            user_2.AutoSize = true;
            user_2.BackColor = SystemColors.InactiveCaptionText;
            user_2.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_2.ForeColor = SystemColors.ButtonHighlight;
            user_2.Location = new Point(74, 173);
            user_2.Name = "user_2";
            user_2.Size = new Size(166, 23);
            user_2.TabIndex = 24;
            user_2.Text = "systemdefault";
            user_2.Visible = false;
            // 
            // user_3
            // 
            user_3.AutoSize = true;
            user_3.BackColor = SystemColors.InactiveCaptionText;
            user_3.Font = new Font("SimSun", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_3.ForeColor = SystemColors.ButtonHighlight;
            user_3.Location = new Point(76, 215);
            user_3.Name = "user_3";
            user_3.Size = new Size(166, 23);
            user_3.TabIndex = 25;
            user_3.Text = "systemdefault";
            user_3.Visible = false;
            // 
            // lbl_credits
            // 
            lbl_credits.AutoSize = true;
            lbl_credits.BackColor = SystemColors.InactiveCaptionText;
            lbl_credits.Font = new Font("SimSun", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_credits.ForeColor = SystemColors.ButtonHighlight;
            lbl_credits.Location = new Point(585, 549);
            lbl_credits.Name = "lbl_credits";
            lbl_credits.Size = new Size(175, 39);
            lbl_credits.TabIndex = 26;
            lbl_credits.Text = "       Credits : \r\nMostafa, Maria, felipe, \r\n     yuvraj, deepu";
            lbl_credits.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1268, 628);
            Controls.Add(lbl_credits);
            Controls.Add(user_3);
            Controls.Add(user_2);
            Controls.Add(user_1);
            Controls.Add(lbl_ScoreBoard);
            Controls.Add(lbl_title);
            Controls.Add(lbl_ready);
            Controls.Add(btn_Start);
            Controls.Add(lbl_turn);
            Controls.Add(output_PlayerName);
            Controls.Add(lbl_Overall);
            Controls.Add(lbl_HighScore);
            Controls.Add(lbl_Score);
            Controls.Add(btn_NewGame);
            Controls.Add(label1);
            Controls.Add(btn_Blue);
            Controls.Add(btn_Red);
            Controls.Add(btn_Green);
            Controls.Add(btn_Yellow);
            Name = "Form1";
            Text = "Simon Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Yellow;
        private Button btn_Green;
        private Button btn_Red;
        private Button btn_Blue;
        private Label label1;
        private Button btn_NewGame;
        private Label lbl_Overall;
        private Label lbl_turn;
        private Button btn_Start;
        public Label output_PlayerName;
        public Label lbl_Score;
        public Label lbl_ready;
        private Label lbl_title;
        public Label lbl_HighScore;
        private Label lbl_ScoreBoard;
        public Label user_1;
        public Label user_2;
        public Label user_3;
        public Label lbl_credits;
    }
}
