
namespace DinoGameWithClasses
{
    partial class FRM_DinoGameWithClasses
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
            this.components = new System.ComponentModel.Container();
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
            this.GB_Mainscreen = new System.Windows.Forms.GroupBox();
            this.RB_Easy = new System.Windows.Forms.RadioButton();
            this.RB_Hard = new System.Windows.Forms.RadioButton();
            this.RB_Normal = new System.Windows.Forms.RadioButton();
            this.GB_HowtoplayScreen = new System.Windows.Forms.GroupBox();
            this.BTN_P2Wall = new System.Windows.Forms.Button();
            this.BTN_P1Wall = new System.Windows.Forms.Button();
            this.BTN_P2Right = new System.Windows.Forms.Button();
            this.BTN_P2Down = new System.Windows.Forms.Button();
            this.BTN_P2Left = new System.Windows.Forms.Button();
            this.BTN_P2Up = new System.Windows.Forms.Button();
            this.BTN_P1Right = new System.Windows.Forms.Button();
            this.BTN_P1Down = new System.Windows.Forms.Button();
            this.BTN_P1Left = new System.Windows.Forms.Button();
            this.BTN_P1Up = new System.Windows.Forms.Button();
            this.LBL_P2Keys = new System.Windows.Forms.Label();
            this.LBL_P1Keys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TMR_AiMovement = new System.Windows.Forms.Timer(this.components);
            this.TMR_GameTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TMR_MatchTimer = new System.Windows.Forms.Timer(this.components);
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
            this.PB_MainScreen.BackgroundImage = global::DinoGameWithClasses.Properties.Resources.DG_MainScreen;
            this.PB_MainScreen.Location = new System.Drawing.Point(0, 0);
            this.PB_MainScreen.Name = "PB_MainScreen";
            this.PB_MainScreen.Size = new System.Drawing.Size(396, 450);
            this.PB_MainScreen.TabIndex = 2;
            this.PB_MainScreen.TabStop = false;
            // 
            // BTN_Multiplayer
            // 
            this.BTN_Multiplayer.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.BTN_SinglePlayer.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.BTN_HowToPlay.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.PB_HowtoplayScreen.Image = global::DinoGameWithClasses.Properties.Resources.DG_HowtoplayScreen4;
            this.PB_HowtoplayScreen.Location = new System.Drawing.Point(0, 0);
            this.PB_HowtoplayScreen.Name = "PB_HowtoplayScreen";
            this.PB_HowtoplayScreen.Size = new System.Drawing.Size(396, 450);
            this.PB_HowtoplayScreen.TabIndex = 6;
            this.PB_HowtoplayScreen.TabStop = false;
            // 
            // BTN_Return
            // 
            this.BTN_Return.Font = new System.Drawing.Font("Minecraft", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.LBL_Howtoplay.Font = new System.Drawing.Font("Minecraft", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.LBL_Controlls.Font = new System.Drawing.Font("Minecraft", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Controlls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Controlls.Location = new System.Drawing.Point(102, 186);
            this.LBL_Controlls.Name = "LBL_Controlls";
            this.LBL_Controlls.Size = new System.Drawing.Size(187, 39);
            this.LBL_Controlls.TabIndex = 11;
            this.LBL_Controlls.Text = "Controlls";
            this.LBL_Controlls.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Theobjectiveisto
            // 
            this.LBL_Theobjectiveisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Theobjectiveisto.Font = new System.Drawing.Font("Minecraft", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Theobjectiveisto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Theobjectiveisto.Location = new System.Drawing.Point(29, 95);
            this.LBL_Theobjectiveisto.Name = "LBL_Theobjectiveisto";
            this.LBL_Theobjectiveisto.Size = new System.Drawing.Size(339, 91);
            this.LBL_Theobjectiveisto.TabIndex = 12;
            this.LBL_Theobjectiveisto.Text = "The objective is to collect more blocks than your opponent, you can build walls t" +
    "o block your oppnent";
            this.LBL_Theobjectiveisto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Player1
            // 
            this.LBL_Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player1.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player1.Location = new System.Drawing.Point(29, 225);
            this.LBL_Player1.Name = "LBL_Player1";
            this.LBL_Player1.Size = new System.Drawing.Size(134, 33);
            this.LBL_Player1.TabIndex = 13;
            this.LBL_Player1.Text = "Player 1";
            // 
            // LBL_Player2
            // 
            this.LBL_Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player2.Font = new System.Drawing.Font("Minecraft", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player2.Location = new System.Drawing.Point(216, 225);
            this.LBL_Player2.Name = "LBL_Player2";
            this.LBL_Player2.Size = new System.Drawing.Size(136, 33);
            this.LBL_Player2.TabIndex = 14;
            this.LBL_Player2.Text = "Player 2";
            // 
            // LBL_Player1Settings
            // 
            this.LBL_Player1Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_Player1Settings.Font = new System.Drawing.Font("Minecraft", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Player1Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_Player1Settings.Location = new System.Drawing.Point(29, 257);
            this.LBL_Player1Settings.Name = "LBL_Player1Settings";
            this.LBL_Player1Settings.Size = new System.Drawing.Size(110, 58);
            this.LBL_Player1Settings.TabIndex = 15;
            this.LBL_Player1Settings.Text = "Movement\r\n";
            // 
            // GB_Mainscreen
            // 
            this.GB_Mainscreen.Controls.Add(this.RB_Easy);
            this.GB_Mainscreen.Controls.Add(this.RB_Hard);
            this.GB_Mainscreen.Controls.Add(this.RB_Normal);
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
            // RB_Easy
            // 
            this.RB_Easy.AutoSize = true;
            this.RB_Easy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RB_Easy.Checked = true;
            this.RB_Easy.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RB_Easy.ForeColor = System.Drawing.Color.GreenYellow;
            this.RB_Easy.Location = new System.Drawing.Point(56, 258);
            this.RB_Easy.Name = "RB_Easy";
            this.RB_Easy.Size = new System.Drawing.Size(67, 19);
            this.RB_Easy.TabIndex = 8;
            this.RB_Easy.TabStop = true;
            this.RB_Easy.Text = "Easy";
            this.RB_Easy.UseVisualStyleBackColor = false;
            // 
            // RB_Hard
            // 
            this.RB_Hard.AutoSize = true;
            this.RB_Hard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RB_Hard.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RB_Hard.ForeColor = System.Drawing.Color.GreenYellow;
            this.RB_Hard.Location = new System.Drawing.Point(252, 258);
            this.RB_Hard.Name = "RB_Hard";
            this.RB_Hard.Size = new System.Drawing.Size(67, 19);
            this.RB_Hard.TabIndex = 7;
            this.RB_Hard.Text = "Hard";
            this.RB_Hard.UseVisualStyleBackColor = false;
            // 
            // RB_Normal
            // 
            this.RB_Normal.AutoSize = true;
            this.RB_Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RB_Normal.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RB_Normal.ForeColor = System.Drawing.Color.GreenYellow;
            this.RB_Normal.Location = new System.Drawing.Point(147, 258);
            this.RB_Normal.Name = "RB_Normal";
            this.RB_Normal.Size = new System.Drawing.Size(86, 19);
            this.RB_Normal.TabIndex = 6;
            this.RB_Normal.Text = "Normal";
            this.RB_Normal.UseVisualStyleBackColor = false;
            // 
            // GB_HowtoplayScreen
            // 
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P2Wall);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P1Wall);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P2Right);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P2Down);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P2Left);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P2Up);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P1Right);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P1Down);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P1Left);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_P1Up);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_P2Keys);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_P1Keys);
            this.GB_HowtoplayScreen.Controls.Add(this.label1);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Controlls);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Theobjectiveisto);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Howtoplay);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player1);
            this.GB_HowtoplayScreen.Controls.Add(this.BTN_Return);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player2);
            this.GB_HowtoplayScreen.Controls.Add(this.LBL_Player1Settings);
            this.GB_HowtoplayScreen.Controls.Add(this.PB_HowtoplayScreen);
            this.GB_HowtoplayScreen.Location = new System.Drawing.Point(398, 0);
            this.GB_HowtoplayScreen.Name = "GB_HowtoplayScreen";
            this.GB_HowtoplayScreen.Size = new System.Drawing.Size(396, 475);
            this.GB_HowtoplayScreen.TabIndex = 0;
            this.GB_HowtoplayScreen.TabStop = false;
            this.GB_HowtoplayScreen.Visible = false;
            // 
            // BTN_P2Wall
            // 
            this.BTN_P2Wall.Location = new System.Drawing.Point(204, 350);
            this.BTN_P2Wall.Name = "BTN_P2Wall";
            this.BTN_P2Wall.Size = new System.Drawing.Size(10, 10);
            this.BTN_P2Wall.TabIndex = 28;
            this.BTN_P2Wall.Text = "button1";
            this.BTN_P2Wall.UseVisualStyleBackColor = true;
            this.BTN_P2Wall.Click += new System.EventHandler(this.BTN_P2Wall_Click);
            // 
            // BTN_P1Wall
            // 
            this.BTN_P1Wall.Location = new System.Drawing.Point(13, 350);
            this.BTN_P1Wall.Name = "BTN_P1Wall";
            this.BTN_P1Wall.Size = new System.Drawing.Size(10, 10);
            this.BTN_P1Wall.TabIndex = 27;
            this.BTN_P1Wall.Text = "button1";
            this.BTN_P1Wall.UseVisualStyleBackColor = true;
            this.BTN_P1Wall.Click += new System.EventHandler(this.BTN_P1Wall_Click);
            // 
            // BTN_P2Right
            // 
            this.BTN_P2Right.Location = new System.Drawing.Point(204, 334);
            this.BTN_P2Right.Name = "BTN_P2Right";
            this.BTN_P2Right.Size = new System.Drawing.Size(10, 10);
            this.BTN_P2Right.TabIndex = 26;
            this.BTN_P2Right.Text = "button1";
            this.BTN_P2Right.UseVisualStyleBackColor = true;
            this.BTN_P2Right.Click += new System.EventHandler(this.BTN_P2Right_Click);
            // 
            // BTN_P2Down
            // 
            this.BTN_P2Down.Location = new System.Drawing.Point(204, 318);
            this.BTN_P2Down.Name = "BTN_P2Down";
            this.BTN_P2Down.Size = new System.Drawing.Size(10, 10);
            this.BTN_P2Down.TabIndex = 25;
            this.BTN_P2Down.Text = "button1";
            this.BTN_P2Down.UseVisualStyleBackColor = true;
            this.BTN_P2Down.Click += new System.EventHandler(this.BTN_P2Down_Click);
            // 
            // BTN_P2Left
            // 
            this.BTN_P2Left.Location = new System.Drawing.Point(204, 302);
            this.BTN_P2Left.Name = "BTN_P2Left";
            this.BTN_P2Left.Size = new System.Drawing.Size(10, 10);
            this.BTN_P2Left.TabIndex = 24;
            this.BTN_P2Left.Text = "button1";
            this.BTN_P2Left.UseVisualStyleBackColor = true;
            this.BTN_P2Left.Click += new System.EventHandler(this.BTN_P2Left_Click);
            // 
            // BTN_P2Up
            // 
            this.BTN_P2Up.Location = new System.Drawing.Point(204, 286);
            this.BTN_P2Up.Name = "BTN_P2Up";
            this.BTN_P2Up.Size = new System.Drawing.Size(10, 10);
            this.BTN_P2Up.TabIndex = 23;
            this.BTN_P2Up.Text = "button1";
            this.BTN_P2Up.UseVisualStyleBackColor = true;
            this.BTN_P2Up.Click += new System.EventHandler(this.BTN_P2Up_Click);
            // 
            // BTN_P1Right
            // 
            this.BTN_P1Right.Location = new System.Drawing.Point(13, 334);
            this.BTN_P1Right.Name = "BTN_P1Right";
            this.BTN_P1Right.Size = new System.Drawing.Size(10, 10);
            this.BTN_P1Right.TabIndex = 22;
            this.BTN_P1Right.Text = "button1";
            this.BTN_P1Right.UseVisualStyleBackColor = true;
            this.BTN_P1Right.Click += new System.EventHandler(this.BTN_P1Right_Click);
            // 
            // BTN_P1Down
            // 
            this.BTN_P1Down.Location = new System.Drawing.Point(13, 318);
            this.BTN_P1Down.Name = "BTN_P1Down";
            this.BTN_P1Down.Size = new System.Drawing.Size(10, 10);
            this.BTN_P1Down.TabIndex = 21;
            this.BTN_P1Down.Text = "button1";
            this.BTN_P1Down.UseVisualStyleBackColor = true;
            this.BTN_P1Down.Click += new System.EventHandler(this.BTN_P1Down_Click);
            // 
            // BTN_P1Left
            // 
            this.BTN_P1Left.Location = new System.Drawing.Point(13, 302);
            this.BTN_P1Left.Name = "BTN_P1Left";
            this.BTN_P1Left.Size = new System.Drawing.Size(10, 10);
            this.BTN_P1Left.TabIndex = 20;
            this.BTN_P1Left.Text = "button1";
            this.BTN_P1Left.UseVisualStyleBackColor = true;
            this.BTN_P1Left.Click += new System.EventHandler(this.BTN_P1Left_Click);
            // 
            // BTN_P1Up
            // 
            this.BTN_P1Up.Location = new System.Drawing.Point(13, 286);
            this.BTN_P1Up.Name = "BTN_P1Up";
            this.BTN_P1Up.Size = new System.Drawing.Size(10, 10);
            this.BTN_P1Up.TabIndex = 19;
            this.BTN_P1Up.Text = "button1";
            this.BTN_P1Up.UseVisualStyleBackColor = true;
            this.BTN_P1Up.Click += new System.EventHandler(this.BTN_P1Up_Click);
            // 
            // LBL_P2Keys
            // 
            this.LBL_P2Keys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_P2Keys.Font = new System.Drawing.Font("Minecraft", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_P2Keys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_P2Keys.Location = new System.Drawing.Point(220, 284);
            this.LBL_P2Keys.Name = "LBL_P2Keys";
            this.LBL_P2Keys.Size = new System.Drawing.Size(170, 95);
            this.LBL_P2Keys.TabIndex = 18;
            this.LBL_P2Keys.Text = "Up - NumPad8\r\nLeft - NumPad4\r\nDown - NumPad5\r\nRight - NumPad6\r\nWall - NumPad0";
            // 
            // LBL_P1Keys
            // 
            this.LBL_P1Keys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.LBL_P1Keys.Font = new System.Drawing.Font("Minecraft", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_P1Keys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.LBL_P1Keys.Location = new System.Drawing.Point(29, 284);
            this.LBL_P1Keys.Name = "LBL_P1Keys";
            this.LBL_P1Keys.Size = new System.Drawing.Size(169, 95);
            this.LBL_P1Keys.TabIndex = 17;
            this.LBL_P1Keys.Text = "Up - W\r\nLeft - A\r\nDown - S\r\nRight - D \r\nWall - F";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.label1.Font = new System.Drawing.Font("Minecraft", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(216, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movement\r\n";
            // 
            // TMR_AiMovement
            // 
            this.TMR_AiMovement.Interval = 300;
            this.TMR_AiMovement.Tick += new System.EventHandler(this.TMR_Ai_Tick);
            // 
            // TMR_GameTime
            // 
            this.TMR_GameTime.Interval = 1;
            this.TMR_GameTime.Tick += new System.EventHandler(this.TMR_GameTime_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // TMR_MatchTimer
            // 
            this.TMR_MatchTimer.Interval = 1000;
            this.TMR_MatchTimer.Tick += new System.EventHandler(this.TMR_MatchTimer_Tick);
            // 
            // FRM_DinoGameWithClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::DinoGameWithClasses.Properties.Resources.DG_Grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 449);
            this.Controls.Add(this.GB_HowtoplayScreen);
            this.Controls.Add(this.GB_Mainscreen);
            this.Controls.Add(this.LBL_Seconds);
            this.Controls.Add(this.LBL_Time);
            this.Controls.Add(this.LBL_Player2Points);
            this.Controls.Add(this.LBL_Player1Points);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_DinoGameWithClasses";
            this.Text = "DinoGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_DinoGameWithClasses_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRM_DinoGameWithClasses_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_HowtoplayScreen)).EndInit();
            this.GB_Mainscreen.ResumeLayout(false);
            this.GB_Mainscreen.PerformLayout();
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
        private System.Windows.Forms.Label LBL_Player2Points;
        private System.Windows.Forms.GroupBox GB_Mainscreen;
        private System.Windows.Forms.GroupBox GB_HowtoplayScreen;
        private System.Windows.Forms.Timer TMR_AiMovement;
        private System.Windows.Forms.Timer TMR_GameTime;
        private System.Windows.Forms.RadioButton RB_Easy;
        private System.Windows.Forms.RadioButton RB_Hard;
        private System.Windows.Forms.RadioButton RB_Normal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TMR_MatchTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_P1Up;
        private System.Windows.Forms.Label LBL_P2Keys;
        private System.Windows.Forms.Label LBL_P1Keys;
        private System.Windows.Forms.Button BTN_P1Left;
        private System.Windows.Forms.Button BTN_P1Right;
        private System.Windows.Forms.Button BTN_P1Down;
        private System.Windows.Forms.Button BTN_P2Right;
        private System.Windows.Forms.Button BTN_P2Down;
        private System.Windows.Forms.Button BTN_P2Left;
        private System.Windows.Forms.Button BTN_P2Up;
        private System.Windows.Forms.Button BTN_P2Wall;
        private System.Windows.Forms.Button BTN_P1Wall;
    }
}

