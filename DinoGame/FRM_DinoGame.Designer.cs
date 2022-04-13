
namespace DinoGame
{
    partial class FRM_DinoGame
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
            this.LBL_Player1Points = new System.Windows.Forms.Label();
            this.LBL_Player2Points = new System.Windows.Forms.Label();
            this.PB_MainScreen = new System.Windows.Forms.PictureBox();
            this.BTN_Multiplayer = new System.Windows.Forms.Button();
            this.BTN_SinglePlayer = new System.Windows.Forms.Button();
            this.BTN_HowToPlay = new System.Windows.Forms.Button();
            this.PB_HowtoplayScreen = new System.Windows.Forms.PictureBox();
            this.BTN_Return = new System.Windows.Forms.Button();
            this.LBL_Time = new System.Windows.Forms.Label();
            this.LBL_Seconds = new System.Windows.Forms.Label();
            this.LBL_Howtoplay = new System.Windows.Forms.Label();
            this.LBL_Controlls = new System.Windows.Forms.Label();
            this.LBL_Theobjectiveisto = new System.Windows.Forms.Label();
            this.LBL_Player1 = new System.Windows.Forms.Label();
            this.LBL_Player2 = new System.Windows.Forms.Label();
            this.LBL_Player1Settings = new System.Windows.Forms.Label();
            this.LBL_Player2Settings = new System.Windows.Forms.Label();
            this.GB_Mainscreen = new System.Windows.Forms.GroupBox();
            this.GB_HowtoplayScreen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_HowtoplayScreen)).BeginInit();
            this.GB_Mainscreen.SuspendLayout();
            this.GB_HowtoplayScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Player1Points
            // 
            this.LBL_Player1Points.AutoSize = true;
            this.LBL_Player1Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player1Points.ForeColor = System.Drawing.Color.Blue;
            this.LBL_Player1Points.Location = new System.Drawing.Point(0, 405);
            this.LBL_Player1Points.Name = "LBL_Player1Points";
            this.LBL_Player1Points.Size = new System.Drawing.Size(100, 25);
            this.LBL_Player1Points.TabIndex = 0;
            this.LBL_Player1Points.Text = "Player1: 0";
            this.LBL_Player1Points.Visible = false;
            // 
            // LBL_Player2Points
            // 
            this.LBL_Player2Points.AutoSize = true;
            this.LBL_Player2Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player2Points.ForeColor = System.Drawing.Color.Red;
            this.LBL_Player2Points.Location = new System.Drawing.Point(242, 405);
            this.LBL_Player2Points.Name = "LBL_Player2Points";
            this.LBL_Player2Points.Size = new System.Drawing.Size(100, 25);
            this.LBL_Player2Points.TabIndex = 1;
            this.LBL_Player2Points.Text = "Player2: 0";
            this.LBL_Player2Points.Visible = false;
            // 
            // PB_MainScreen
            // 
            this.PB_MainScreen.BackgroundImage = global::DinoGame.Properties.Resources.DG_MainScreen;
            this.PB_MainScreen.Location = new System.Drawing.Point(0, 0);
            this.PB_MainScreen.Name = "PB_MainScreen";
            this.PB_MainScreen.Size = new System.Drawing.Size(396, 450);
            this.PB_MainScreen.TabIndex = 2;
            this.PB_MainScreen.TabStop = false;
            // 
            // BTN_Multiplayer
            // 
            this.BTN_Multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Multiplayer.ForeColor = System.Drawing.Color.Purple;
            this.BTN_Multiplayer.Location = new System.Drawing.Point(56, 334);
            this.BTN_Multiplayer.Name = "BTN_Multiplayer";
            this.BTN_Multiplayer.Size = new System.Drawing.Size(276, 31);
            this.BTN_Multiplayer.TabIndex = 3;
            this.BTN_Multiplayer.Text = "Mulitplayer";
            this.BTN_Multiplayer.UseVisualStyleBackColor = true;
            this.BTN_Multiplayer.Click += new System.EventHandler(this.BTN_Multiplayer_Click);
            // 
            // BTN_SinglePlayer
            // 
            this.BTN_SinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_SinglePlayer.ForeColor = System.Drawing.Color.Purple;
            this.BTN_SinglePlayer.Location = new System.Drawing.Point(56, 297);
            this.BTN_SinglePlayer.Name = "BTN_SinglePlayer";
            this.BTN_SinglePlayer.Size = new System.Drawing.Size(276, 31);
            this.BTN_SinglePlayer.TabIndex = 4;
            this.BTN_SinglePlayer.Text = "Singleplayer";
            this.BTN_SinglePlayer.UseVisualStyleBackColor = true;
            this.BTN_SinglePlayer.Click += new System.EventHandler(this.BTN_SinglePlayer_Click);
            // 
            // BTN_HowToPlay
            // 
            this.BTN_HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_HowToPlay.ForeColor = System.Drawing.Color.Purple;
            this.BTN_HowToPlay.Location = new System.Drawing.Point(56, 371);
            this.BTN_HowToPlay.Name = "BTN_HowToPlay";
            this.BTN_HowToPlay.Size = new System.Drawing.Size(276, 31);
            this.BTN_HowToPlay.TabIndex = 5;
            this.BTN_HowToPlay.Text = "How to play";
            this.BTN_HowToPlay.UseVisualStyleBackColor = true;
            this.BTN_HowToPlay.Click += new System.EventHandler(this.BTN_HowToPlay_Click);
            // 
            // PB_HowtoplayScreen
            // 
            this.PB_HowtoplayScreen.Image = global::DinoGame.Properties.Resources.DG_HowtoplayScreen4;
            this.PB_HowtoplayScreen.Location = new System.Drawing.Point(0, 0);
            this.PB_HowtoplayScreen.Name = "PB_HowtoplayScreen";
            this.PB_HowtoplayScreen.Size = new System.Drawing.Size(396, 450);
            this.PB_HowtoplayScreen.TabIndex = 6;
            this.PB_HowtoplayScreen.TabStop = false;
            // 
            // BTN_Return
            // 
            this.BTN_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Return.ForeColor = System.Drawing.Color.Purple;
            this.BTN_Return.Location = new System.Drawing.Point(145, 403);
            this.BTN_Return.Name = "BTN_Return";
            this.BTN_Return.Size = new System.Drawing.Size(102, 29);
            this.BTN_Return.TabIndex = 7;
            this.BTN_Return.Text = "Return";
            this.BTN_Return.UseVisualStyleBackColor = true;
            this.BTN_Return.Click += new System.EventHandler(this.BTN_Return_Click);
            // 
            // LBL_Time
            // 
            this.LBL_Time.AutoSize = true;
            this.LBL_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LBL_Time.Location = new System.Drawing.Point(167, 399);
            this.LBL_Time.Name = "LBL_Time";
            this.LBL_Time.Size = new System.Drawing.Size(39, 17);
            this.LBL_Time.TabIndex = 8;
            this.LBL_Time.Text = "Time";
            this.LBL_Time.Visible = false;
            // 
            // LBL_Seconds
            // 
            this.LBL_Seconds.AutoSize = true;
            this.LBL_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Seconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LBL_Seconds.Location = new System.Drawing.Point(177, 421);
            this.LBL_Seconds.Name = "LBL_Seconds";
            this.LBL_Seconds.Size = new System.Drawing.Size(24, 17);
            this.LBL_Seconds.TabIndex = 9;
            this.LBL_Seconds.Text = "60";
            this.LBL_Seconds.Visible = false;
            // 
            // LBL_Howtoplay
            // 
            this.LBL_Howtoplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Howtoplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Howtoplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Howtoplay.Location = new System.Drawing.Point(29, 21);
            this.LBL_Howtoplay.Name = "LBL_Howtoplay";
            this.LBL_Howtoplay.Size = new System.Drawing.Size(339, 69);
            this.LBL_Howtoplay.TabIndex = 10;
            this.LBL_Howtoplay.Text = "How to play";
            this.LBL_Howtoplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Controlls
            // 
            this.LBL_Controlls.AutoSize = true;
            this.LBL_Controlls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Controlls.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Controlls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Controlls.Location = new System.Drawing.Point(76, 258);
            this.LBL_Controlls.Name = "LBL_Controlls";
            this.LBL_Controlls.Size = new System.Drawing.Size(175, 44);
            this.LBL_Controlls.TabIndex = 11;
            this.LBL_Controlls.Text = "Controlls";
            this.LBL_Controlls.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Theobjectiveisto
            // 
            this.LBL_Theobjectiveisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Theobjectiveisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Theobjectiveisto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Theobjectiveisto.Location = new System.Drawing.Point(29, 95);
            this.LBL_Theobjectiveisto.Name = "LBL_Theobjectiveisto";
            this.LBL_Theobjectiveisto.Size = new System.Drawing.Size(339, 173);
            this.LBL_Theobjectiveisto.TabIndex = 12;
            this.LBL_Theobjectiveisto.Text = "The objective is to collect more blocks than your opponent, you can build walls t" +
    "o thwart your oppnent";
            this.LBL_Theobjectiveisto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Player1
            // 
            this.LBL_Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player1.Location = new System.Drawing.Point(29, 327);
            this.LBL_Player1.Name = "LBL_Player1";
            this.LBL_Player1.Size = new System.Drawing.Size(110, 36);
            this.LBL_Player1.TabIndex = 13;
            this.LBL_Player1.Text = "Player 1";
            // 
            // LBL_Player2
            // 
            this.LBL_Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player2.Location = new System.Drawing.Point(254, 327);
            this.LBL_Player2.Name = "LBL_Player2";
            this.LBL_Player2.Size = new System.Drawing.Size(114, 36);
            this.LBL_Player2.TabIndex = 14;
            this.LBL_Player2.Text = "Player 2";
            // 
            // LBL_Player1Settings
            // 
            this.LBL_Player1Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player1Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player1Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player1Settings.Location = new System.Drawing.Point(29, 363);
            this.LBL_Player1Settings.Name = "LBL_Player1Settings";
            this.LBL_Player1Settings.Size = new System.Drawing.Size(127, 58);
            this.LBL_Player1Settings.TabIndex = 15;
            this.LBL_Player1Settings.Text = "Move: W,A,S,D Wall: F";
            // 
            // LBL_Player2Settings
            // 
            this.LBL_Player2Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player2Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player2Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player2Settings.Location = new System.Drawing.Point(254, 363);
            this.LBL_Player2Settings.Name = "LBL_Player2Settings";
            this.LBL_Player2Settings.Size = new System.Drawing.Size(127, 69);
            this.LBL_Player2Settings.TabIndex = 16;
            this.LBL_Player2Settings.Text = "Move: 8,4,5,6\r\nWall: 0\r\n(use numpad)";
            // 
            // GB_Mainscreen
            // 
            this.GB_Mainscreen.Controls.Add(this.BTN_Multiplayer);
            this.GB_Mainscreen.Controls.Add(this.BTN_SinglePlayer);
            this.GB_Mainscreen.Controls.Add(this.BTN_HowToPlay);
            this.GB_Mainscreen.Controls.Add(this.PB_MainScreen);
            this.GB_Mainscreen.Location = new System.Drawing.Point(0, 0);
            this.GB_Mainscreen.Name = "GB_Mainscreen";
            this.GB_Mainscreen.Size = new System.Drawing.Size(396, 475);
            this.GB_Mainscreen.TabIndex = 17;
            this.GB_Mainscreen.TabStop = false;
            // 
            // GB_HowtoplayScreen
            // 
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Controlls);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Theobjectiveisto);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Howtoplay);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player1);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_Return);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player2);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player2Settings);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player1Settings);
            this.GB_HowtoplayScreen.Controls.Add(this.PB_HowtoplayScreen);
            this.GB_HowtoplayScreen.Location = new System.Drawing.Point(398, 0);
            this.GB_HowtoplayScreen.Name = "GB_HowtoplayScreen";
            this.GB_HowtoplayScreen.Size = new System.Drawing.Size(396, 475);
            this.GB_HowtoplayScreen.TabIndex = 0;
            this.GB_HowtoplayScreen.TabStop = false;
            this.GB_HowtoplayScreen.Visible = false;
            // 
            // FRM_DinoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::DinoGame.Properties.Resources.DG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 449);
            this.Controls.Add(this.GB_HowtoplayScreen);
            this.Controls.Add(this.GB_Mainscreen);
            this.Controls.Add(this.LBL_Seconds);
            this.Controls.Add(this.LBL_Time);
            this.Controls.Add(this.LBL_Player2Points);
            this.Controls.Add(this.LBL_Player1Points);
            this.Name = "FRM_DinoGame";
            this.Text = "DinoGame";
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_HowtoplayScreen)).EndInit();
            this.GB_Mainscreen.ResumeLayout(false);
            this.GB_HowtoplayScreen.ResumeLayout(false);
            this.GB_HowtoplayScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Player1Points;
        private System.Windows.Forms.PictureBox PB_MainScreen;
        private System.Windows.Forms.Button BTN_Multiplayer;
        private System.Windows.Forms.Button BTN_SinglePlayer;
        private System.Windows.Forms.Button BTN_HowToPlay;
        private System.Windows.Forms.PictureBox PB_HowtoplayScreen;
        private System.Windows.Forms.Button BTN_Return;
        private System.Windows.Forms.Label LBL_Time;
        private System.Windows.Forms.Label LBL_Seconds;
        private System.Windows.Forms.Label LBL_Howtoplay;
        private System.Windows.Forms.Label LBL_Controlls;
        private System.Windows.Forms.Label LBL_Theobjectiveisto;
        private System.Windows.Forms.Label LBL_Player1;
        private System.Windows.Forms.Label LBL_Player2;
        private System.Windows.Forms.Label LBL_Player1Settings;
        private System.Windows.Forms.Label LBL_Player2Settings;
        private System.Windows.Forms.Label LBL_Player2Points;
        private System.Windows.Forms.GroupBox GB_Mainscreen;
        private System.Windows.Forms.GroupBox GB_HowtoplayScreen;
    }
}

