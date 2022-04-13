using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoGameWithClasses
{
    enum GameState
    {
        None,
        Singleplayer,
        Multiplayer
    }
    public partial class FRM_DinoGameWithClasses : Form
    {
        // Objects
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        Timer myTimer = new Timer();
        Random rnd = new Random();
        Food food = new Food();
        Player Player1 = new Player();
        Player Player2 = new Player();
        AI ai = new AI();
        Wall W1P1 = new Wall();
        Wall W2P1 = new Wall();
        Wall W1P2 = new Wall();
        Wall W2P2 = new Wall();
        ListBox playerOneListBox = new ListBox();
        ListBox playerTwoListBox = new ListBox();
        ListBox foodListBox = new ListBox();
        ListBox wallOnePlayer1ListBox = new ListBox();
        ListBox wallTwoPlayer1ListBox = new ListBox();
        ListBox wallOnePlayer2ListBox = new ListBox();
        ListBox wallTwoPlayer2ListBox = new ListBox();
        GameState gameState = new GameState();
        Difficulty difficulty = new Difficulty();

        public FRM_DinoGameWithClasses()
        {
            InitializeComponent();

            music.SoundLocation = "Underclocked.wav";

            Player1.Modifylocation(0, 0);
            Player2.Modifylocation(352, 352);
            ai.Modifylocation(352, 352);

            moveUpPlayer1 = Keys.W;
            moveLeftPlayer1 = Keys.A;
            moveDownPlayer1 = Keys.S;
            moveRightPlayer1 = Keys.D;
            buildWallPlayer1 = Keys.F;

            moveUpPlayer2 = Keys.NumPad8;
            moveLeftPlayer2 = Keys.NumPad4;
            moveDownPlayer2 = Keys.NumPad5;
            moveRightPlayer2 = Keys.NumPad6;
            buildWallPlayer2 = Keys.NumPad0;
        }

        // Fields
        const int constGameTime = 60;
        int gameTime;
        // Player 1 Keys
        Keys moveUpPlayer1 = new Keys();
        Keys moveLeftPlayer1 = new Keys();
        Keys moveDownPlayer1 = new Keys();
        Keys moveRightPlayer1 = new Keys();
        Keys buildWallPlayer1 = new Keys();
        // player 2 keys
        Keys moveUpPlayer2 = new Keys();
        Keys moveLeftPlayer2 = new Keys();
        Keys moveDownPlayer2 = new Keys();
        Keys moveRightPlayer2 = new Keys();
        Keys buildWallPlayer2 = new Keys();
        string player1Name = "Player 1";
        string player2Name = "Player 2";

        // Keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (gameState == GameState.Multiplayer)
            {
                //--------------------//
                //--BUTTONS PLAYER 1--//
                //--------------------//

                // W (move up)
                if (keyData == moveUpPlayer1)
                {
                    Player1.MoveUp(Player2.XLocation, Player2.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }

                // A (move left)
                if (keyData == moveLeftPlayer1)
                {
                    Player1.MoveLeft(Player2.XLocation, Player2.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }

                // S (move down)
                if (keyData == moveDownPlayer1)
                {
                    Player1.MoveDown(Player2.XLocation, Player2.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }

                // D (move right)
                if (keyData == moveRightPlayer1)
                {
                    Player1.MoveRight(Player2.XLocation, Player2.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }

                // F (place block)
                if (keyData == buildWallPlayer1)
                {
                    // create first wall
                    if (Player1.WallCount == 0)
                    {
                        // save player location and give it to the wall
                        W1P1.SaveLocation(Player1.XLocation, Player1.YLocation);

                        // give listbox values
                        wallOnePlayer1ListBox.Location = new System.Drawing.Point(W1P1.XLocation, W1P1.YLocation);
                        wallOnePlayer1ListBox.Size = new System.Drawing.Size(44, 44);
                        wallOnePlayer1ListBox.BackColor = System.Drawing.Color.DarkBlue;

                        // add listbox to form
                        Controls.Add(wallOnePlayer1ListBox);

                        // there is one wall placed
                        Player1.ModifyWallCount(1);
                    }
                    // create second wall
                    else if (Player1.WallCount == 1)
                    {
                        // save player location and give it to the wall
                        W2P1.SaveLocation(Player1.XLocation, Player1.YLocation);

                        // give listbox values
                        wallTwoPlayer1ListBox.Location = new System.Drawing.Point(W2P1.XLocation, W2P1.YLocation);
                        wallTwoPlayer1ListBox.Size = new System.Drawing.Size(44, 44);
                        wallTwoPlayer1ListBox.BackColor = System.Drawing.Color.DarkBlue;

                        // add listbox to form
                        Controls.Add(wallTwoPlayer1ListBox);

                        // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                        Player1.ModifyWallCount(-1);
                    }
                }

                // playing field
                // 0,44,88,132,176,220,264,308,352

                //--------------------//
                //--BUTTONS PLAYER 2--//
                //--------------------//

                // NumPad8 (move up)
                if (keyData == moveUpPlayer2)
                {
                    Player2.MoveUp(Player1.XLocation, Player1.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation);
                }

                // NumPad4 (move left)
                if (keyData == moveLeftPlayer2)
                {
                    Player2.MoveLeft(Player1.XLocation, Player1.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation);
                }

                // NumPad5 (move down)
                if (keyData == moveDownPlayer2)
                {
                    Player2.MoveDown(Player1.XLocation, Player1.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation);
                }

                // NumPad6 (move right)
                if (keyData == moveRightPlayer2)
                {
                    Player2.MoveRight(Player1.XLocation, Player1.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation);
                }

                // 0 (place block)
                if (keyData == buildWallPlayer2)
                {
                    // create first wall
                    if (Player2.WallCount == 0)
                    {
                        // save player location and give it to the wall
                        W1P2.SaveLocation(Player2.XLocation, Player2.YLocation);

                        // give listbox values
                        wallOnePlayer2ListBox.Location = new System.Drawing.Point(W1P2.XLocation, W1P2.YLocation);
                        wallOnePlayer2ListBox.Size = new System.Drawing.Size(44, 44);
                        wallOnePlayer2ListBox.BackColor = System.Drawing.Color.DarkRed;

                        // add listbox to form
                        Controls.Add(wallOnePlayer2ListBox);

                        // there is one wall placed
                        Player2.ModifyWallCount(1);
                    }
                    // create second wall
                    else if (Player2.WallCount == 1)
                    {
                        // save player location and give it to the wall
                        W2P2.SaveLocation(Player2.XLocation, Player2.YLocation);

                        // give listbox values
                        wallTwoPlayer2ListBox.Location = new System.Drawing.Point(W2P2.XLocation, W2P2.YLocation);
                        wallTwoPlayer2ListBox.Size = new System.Drawing.Size(44, 44);
                        wallTwoPlayer2ListBox.BackColor = System.Drawing.Color.DarkRed;

                        // add listbox to form
                        Controls.Add(wallTwoPlayer2ListBox);

                        // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                        Player2.ModifyWallCount(-1);
                    }
                }

                // check if someone is on the food
                EatFood();

                // Give food and player locations with delete key
                if (keyData == Keys.Delete)
                {
                    MessageBox.Show
                    (
                    "Player1: " + Player1.XLocation + " " + Player1.YLocation + Environment.NewLine +
                    "Player2: " + Player2.XLocation + " " + Player2.YLocation + Environment.NewLine +
                    "Food: " + food.XLocation + " " + food.YLocation
                    );
                }
            }
            if (gameState == GameState.Singleplayer)
            {
                //--------------------//
                //--BUTTONS PLAYER 1--//
                //--------------------//

                if (keyData == moveUpPlayer1)
                {
                    Player1.MoveUp(ai.XLocation, ai.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }
                if (keyData == moveLeftPlayer1)
                {
                    Player1.MoveLeft(ai.XLocation, ai.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }
                if (keyData == moveDownPlayer1)
                {
                    Player1.MoveDown(ai.XLocation, ai.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }
                if (keyData == moveRightPlayer1)
                {
                    Player1.MoveRight(ai.XLocation, ai.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
                }

                // F (place block)
                if (keyData == buildWallPlayer1)
                {
                    // create first wall
                    if (Player1.WallCount == 0)
                    {
                        // save player location and give it to the wall
                        W1P1.SaveLocation(Player1.XLocation, Player1.YLocation);

                        // give listbox values
                        wallOnePlayer1ListBox.Location = new System.Drawing.Point(W1P1.XLocation, W1P1.YLocation);
                        wallOnePlayer1ListBox.Size = new System.Drawing.Size(44, 44);
                        wallOnePlayer1ListBox.BackColor = System.Drawing.Color.DarkBlue;

                        // add listbox to form
                        Controls.Add(wallOnePlayer1ListBox);

                        // there is one wall placed
                        Player1.ModifyWallCount(1);
                    }
                    // create second wall
                    else if (Player1.WallCount == 1)
                    {
                        // save player location and give it to the wall
                        W2P1.SaveLocation(Player1.XLocation, Player1.YLocation);

                        // give listbox values
                        wallTwoPlayer1ListBox.Location = new System.Drawing.Point(W2P1.XLocation, W2P1.YLocation);
                        wallTwoPlayer1ListBox.Size = new System.Drawing.Size(44, 44);
                        wallTwoPlayer1ListBox.BackColor = System.Drawing.Color.DarkBlue;

                        // add listbox to form
                        Controls.Add(wallTwoPlayer1ListBox);

                        // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                        Player1.ModifyWallCount(-1);
                    }
                }

                // playing field
                // 0,44,88,132,176,220,264,308,352

                //--------------------//
                //---------AI---------//
                //--------------------//

                // look at ai class and timer for logic
                
                // Give food and player locations with delete key
                if (keyData == Keys.Delete)
                {
                    MessageBox.Show
                    (
                    "Player1: " + Player1.XLocation + " " + Player1.YLocation + Environment.NewLine +
                    "Player2: " + Player2.XLocation + " " + Player2.YLocation + Environment.NewLine +
                    "Food: " + food.XLocation + " " + food.YLocation
                    );
                }
            }
            if (keyData == Keys.Escape)
            {
                gameTime = 0;
            }
            if (Player1.ChangeUpKey || Player1.ChangeLeftKey || Player1.ChangeDownKey || Player1.ChangeRightKey || Player1.ChangeWallKey)
            {
                CustomizeMovementKeys(keyData);
            }
            if (Player2.ChangeUpKey || Player2.ChangeLeftKey || Player2.ChangeDownKey || Player2.ChangeRightKey || Player2.ChangeWallKey)
            {
                CustomizeMovementKeys(keyData);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        } // ProcessCmdKey

        // Events
        private void BTN_P1Up_Click(object sender, EventArgs e)
        {
            Player1.ModifyChangeUpKey(true);
        }
        private void BTN_P1Left_Click(object sender, EventArgs e)
        {
            Player1.ModifyChangeLeftKey(true);
        }
        private void BTN_P1Down_Click(object sender, EventArgs e)
        {
            Player1.ModifyChangeDownKey(true);
        }
        private void BTN_P1Right_Click(object sender, EventArgs e)
        {
            Player1.ModifyChangeRightKey(true);
        }
        private void BTN_P1Wall_Click(object sender, EventArgs e)
        {
            Player1.ModifyChangeWallKey(true);
        }

        private void BTN_P2Up_Click(object sender, EventArgs e)
        {
            Player2.ModifyChangeUpKey(true);
        }
        private void BTN_P2Left_Click(object sender, EventArgs e)
        {
            Player2.ModifyChangeLeftKey(true);
        }
        private void BTN_P2Down_Click(object sender, EventArgs e)
        {
            Player2.ModifyChangeDownKey(true);
        }
        private void BTN_P2Right_Click(object sender, EventArgs e)
        {
            Player2.ModifyChangeRightKey(true);
        }
        private void BTN_P2Wall_Click(object sender, EventArgs e)
        {
            Player2.ModifyChangeWallKey(true);
        }

        private void FRM_DinoGameWithClasses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gameState == GameState.Singleplayer || gameState == GameState.Multiplayer)
            {
                music.Stop();
                Application.Exit();
            }
        }

        private void BTN_SinglePlayer_Click(object sender, EventArgs e)
        {
            gameState = GameState.Singleplayer;
            PlayingfieldChangeVisibility();
            SetDifficulty();
            gameTime = constGameTime;
            TMR_AiMovement.Enabled = true;
            TMR_GameTime.Enabled = true;
            TMR_MatchTimer.Enabled = true;
            music.Play();
            AddListBoxesToForm();
            SpawnFood();
            LBL_Player2Points.Text = "AI: 0";
            player2Name = "Ai";
        } // BTN_SinglePlayer
        private void BTN_Multiplayer_Click(object sender, EventArgs e)
        {
            gameState = GameState.Multiplayer;
            PlayingfieldChangeVisibility();
            gameTime = constGameTime;
            TMR_GameTime.Enabled = true;
            TMR_MatchTimer.Enabled = true;
            music.Play();
            AddListBoxesToForm();
            SpawnFood();
            player2Name = "Player 2";
        } // BTN_Multiplayer
        private void BTN_HowToPlay_Click(object sender, EventArgs e)
        {
            GB_HowtoplayScreen.Visible = !GB_HowtoplayScreen.Visible;
            GB_Mainscreen.Visible = !GB_Mainscreen.Visible;
        } // BTN_HowToPlay
        private void BTN_Return_Click(object sender, EventArgs e)
        {
            GB_Mainscreen.Visible = !GB_Mainscreen.Visible;
            GB_HowtoplayScreen.Visible = !GB_HowtoplayScreen.Visible;
        } // BTN_Return

        private void TMR_Ai_Tick(object sender, EventArgs e)
        {
            if (ai.BuildWallAlgorithm(food.XLocation, food.YLocation, Player1.XLocation, Player1.YLocation))
            {
                // create first wall
                if (Player2.WallCount == 0)
                {
                    // save player location and give it to the wall
                    W1P2.SaveLocation(ai.XLocation, ai.YLocation);

                    // give listbox values
                    wallOnePlayer2ListBox.Location = new System.Drawing.Point(W1P2.XLocation, W1P2.YLocation);
                    wallOnePlayer2ListBox.Size = new System.Drawing.Size(44, 44);
                    wallOnePlayer2ListBox.BackColor = System.Drawing.Color.Gray;

                    // add listbox to form
                    Controls.Add(wallOnePlayer2ListBox);

                    // there is one wall placed
                    Player2.ModifyWallCount(1);
                }
                // create second wall
                else if (Player2.WallCount == 1)
                {
                    // save player location and give it to the wall
                    W2P2.SaveLocation(ai.XLocation, ai.YLocation);

                    // give listbox values
                    wallTwoPlayer2ListBox.Location = new System.Drawing.Point(W2P2.XLocation, W2P2.YLocation);
                    wallTwoPlayer2ListBox.Size = new System.Drawing.Size(44, 44);
                    wallTwoPlayer2ListBox.BackColor = System.Drawing.Color.Gray;

                    // add listbox to form
                    Controls.Add(wallTwoPlayer2ListBox);

                    // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                    Player2.ModifyWallCount(-1);
                }
            }
            else if (ai.PlaceWallMethod())
            {
                // create first wall
                if (Player2.WallCount == 0)
                {
                    // save player location and give it to the wall
                    W1P2.SaveLocation(ai.XLocation, ai.YLocation);

                    // give listbox values
                    wallOnePlayer2ListBox.Location = new System.Drawing.Point(W1P2.XLocation, W1P2.YLocation);
                    wallOnePlayer2ListBox.Size = new System.Drawing.Size(44, 44);
                    wallOnePlayer2ListBox.BackColor = System.Drawing.Color.Gray;

                    // add listbox to form
                    Controls.Add(wallOnePlayer2ListBox);

                    // there is one wall placed
                    Player2.ModifyWallCount(1);
                }
                // create second wall
                else if (Player2.WallCount == 1)
                {
                    // save player location and give it to the wall
                    W2P2.SaveLocation(ai.XLocation, ai.YLocation);

                    // give listbox values
                    wallTwoPlayer2ListBox.Location = new System.Drawing.Point(W2P2.XLocation, W2P2.YLocation);
                    wallTwoPlayer2ListBox.Size = new System.Drawing.Size(44, 44);
                    wallTwoPlayer2ListBox.BackColor = System.Drawing.Color.Gray;

                    // add listbox to form
                    Controls.Add(wallTwoPlayer2ListBox);

                    // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                    Player2.ModifyWallCount(-1);
                }
                ai.MakePlaceWallFalse();
            }
            ai.AiMovement(food.XLocation, food.YLocation, Player1.XLocation, Player1.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation, Player1.Points);
        }
        private void TMR_GameTime_Tick(object sender, EventArgs e)
        {
            UpdateLocation(playerOneListBox, Player1.XLocation, Player1.YLocation);
            if (gameState == GameState.Multiplayer)
            {
                UpdateLocation(playerTwoListBox, Player2.XLocation, Player2.YLocation);
            }
            if (gameState == GameState.Singleplayer)
            {
                UpdateLocation(playerTwoListBox, ai.XLocation, ai.YLocation);
            }
            EatFood();
        }
        private void TMR_MatchTimer_Tick(object sender, EventArgs e)
        {
            if (gameTime == 0)
            {
                gameTime--;
                gameState = GameState.None;
                DisplayWinner();
                music.Stop();
                PlayingfieldChangeVisibility();
                ResetEverything();

                TMR_AiMovement.Enabled = false;
                TMR_GameTime.Enabled = false;
                TMR_MatchTimer.Enabled = false;
            }
            gameTime--;
            LBL_Seconds.Text = Convert.ToString(gameTime);
        }

        // Methods
        public void CustomizeMovementKeys(Keys keyData)
        {
            if (Player1.ChangeUpKey)
            {
                moveUpPlayer1 = keyData;
                Player1.ModifyChangeUpKey(false);
            }
            if (Player1.ChangeLeftKey)
            {
                moveLeftPlayer1 = keyData;
                Player1.ModifyChangeLeftKey(false);
            }
            if (Player1.ChangeDownKey)
            {
                moveDownPlayer1 = keyData;
                Player1.ModifyChangeDownKey(false);
            }
            if (Player1.ChangeRightKey)
            {
                moveRightPlayer1 = keyData;
                Player1.ModifyChangeRightKey(false);
            }
            if (Player1.ChangeWallKey)
            {
                buildWallPlayer1 = keyData;
                Player1.ModifyChangeWallKey(false);
            }

            if (Player2.ChangeUpKey)
            {
                moveUpPlayer2 = keyData;
                Player2.ModifyChangeUpKey(false);
            }
            if (Player2.ChangeLeftKey)
            {
                moveLeftPlayer2 = keyData;
                Player2.ModifyChangeLeftKey(false);
            }
            if (Player2.ChangeDownKey)
            {
                moveDownPlayer2 = keyData;
                Player2.ModifyChangeDownKey(false);
            }
            if (Player2.ChangeRightKey)
            {
                moveRightPlayer2 = keyData;
                Player2.ModifyChangeRightKey(false);
            }
            if (Player2.ChangeWallKey)
            {
                buildWallPlayer2 = keyData;
                Player2.ModifyChangeWallKey(false);
            }

            string movementPlayerOne = "Up - " + moveUpPlayer1 + "\nLeft - " + moveLeftPlayer1 + "\nDown - " + moveDownPlayer1 + "\nRight - " + moveRightPlayer1 + "\nWall - " + buildWallPlayer1;
            string movementPlayerTwo = "Up - " + moveUpPlayer2 + "\nLeft - " + moveLeftPlayer2 + "\nDown - " + moveDownPlayer2 + "\nRight - " + moveRightPlayer2 + "\nWall - " + buildWallPlayer2;
            LBL_P1Keys.Text = movementPlayerOne;
            LBL_P2Keys.Text = movementPlayerTwo;
        } // kan efficienter?
        private void AddListBoxesToForm()
        {
            if (gameState == GameState.Multiplayer)
            {
                // player 1
                playerOneListBox.Location = new System.Drawing.Point(Player1.XLocation, Player1.YLocation);
                playerOneListBox.Size = new System.Drawing.Size(44, 44);
                playerOneListBox.BackColor = System.Drawing.Color.Blue;
                Controls.Add(playerOneListBox);

                // player 2
                playerTwoListBox.Location = new System.Drawing.Point(Player2.XLocation, Player2.YLocation);
                playerTwoListBox.Size = new System.Drawing.Size(44, 44);
                playerTwoListBox.BackColor = System.Drawing.Color.Red;
                Controls.Add(playerTwoListBox);
            }
            if (gameState == GameState.Singleplayer)
            {
                // player 1
                playerOneListBox.Location = new System.Drawing.Point(Player1.XLocation, Player1.YLocation);
                playerOneListBox.Size = new System.Drawing.Size(44, 44);
                playerOneListBox.BackColor = System.Drawing.Color.Blue;
                Controls.Add(playerOneListBox);

                // AI
                playerTwoListBox.Location = new System.Drawing.Point(ai.XLocation, ai.YLocation);
                playerTwoListBox.Size = new System.Drawing.Size(44, 44);
                playerTwoListBox.BackColor = System.Drawing.Color.Black;
                Controls.Add(playerTwoListBox);
            }

        } // AddListBoxesToForm
        private void SpawnFood()
        {
            // give food listbox values
            foodListBox.Location = new System.Drawing.Point(food.XLocation, food.YLocation);
            foodListBox.Size = new System.Drawing.Size(44, 44);
            foodListBox.BackColor = System.Drawing.Color.MediumPurple;
            Controls.Add(foodListBox);
        } // SpawnFood
        private void EatFood()
        {
            if (gameState == GameState.Multiplayer)
            {
                // check if someone ate food
                if (Player1.XLocation == food.XLocation && Player1.YLocation == food.YLocation || Player2.XLocation == food.XLocation && Player2.YLocation == food.YLocation)
                {
                    // check who ate food
                    if (Player1.XLocation == food.XLocation && Player1.YLocation == food.YLocation)
                    {
                        // remove food
                        Controls.Remove(foodListBox);

                        // give point to player 1
                        Player1.AddPointToScore();
                        LBL_Player1Points.Text = "Player1: " + Player1.Points;
                    }
                    if (Player2.XLocation == food.XLocation && Player2.YLocation == food.YLocation)
                    {
                        // remove food
                        Controls.Remove(foodListBox);

                        // give point to player 2
                        Player2.AddPointToScore();
                        LBL_Player2Points.Text = "Player2: " + Player2.Points;
                    }
                    if (ai.XLocation == food.XLocation && ai.YLocation == food.YLocation)
                    {
                        // remove food
                        Controls.Remove(foodListBox);

                        // give point to player 2
                        ai.AddPointToScore();
                        LBL_Player2Points.Text = "AI: " + ai.Points;
                    }

                    // spawn new food
                    NewFoodLocation();
                    SpawnFood();
                }
            }
            if (gameState == GameState.Singleplayer)
            {
                // check if someone ate food
                if (Player1.XLocation == food.XLocation && Player1.YLocation == food.YLocation || ai.XLocation == food.XLocation && ai.YLocation == food.YLocation)
                {
                    // check who ate food
                    if (Player1.XLocation == food.XLocation && Player1.YLocation == food.YLocation)
                    {
                        // remove food
                        Controls.Remove(foodListBox);

                        // give point to player 1
                        Player1.AddPointToScore();
                        LBL_Player1Points.Text = "Player1: " + Player1.Points;
                    }
                    if (ai.XLocation == food.XLocation && ai.YLocation == food.YLocation)
                    {
                        // remove food
                        Controls.Remove(foodListBox);

                        // give point to ai
                        ai.AddPointToScore();
                        LBL_Player2Points.Text = "AI: " + ai.Points;
                    }

                    // spawn new food
                    NewFoodLocation();
                    SpawnFood();
                }
            }
        } // EatFood
        private void NewFoodLocation()
        {
            if (gameState == GameState.Multiplayer)
            {
                food.FilterGoodLocation(rnd, Player1.XLocation, Player1.YLocation, Player2.XLocation, Player2.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
            }
            if (gameState == GameState.Singleplayer)
            {
                food.FilterGoodLocation(rnd, Player1.XLocation, Player1.YLocation, ai.XLocation, ai.YLocation, W1P1.XLocation, W1P1.YLocation, W2P1.XLocation, W2P1.YLocation, W1P2.XLocation, W1P2.YLocation, W2P2.XLocation, W2P2.YLocation);
            }
            foodListBox.Location = new System.Drawing.Point(food.XLocation, food.YLocation);
        } // NewFoodLocation
        private void PlayingfieldChangeVisibility()
        {
            GB_Mainscreen.Visible = !GB_Mainscreen.Visible;
            LBL_Player1Points.Visible = !LBL_Player1Points.Visible;
            LBL_Player2Points.Visible = !LBL_Player2Points.Visible;
            LBL_Seconds.Visible = !LBL_Seconds.Visible;
            LBL_Time.Visible = !LBL_Time.Visible;
        } // PlayingfieldChangeVisibility
        private void DisplayWinner()
        {
            if (player2Name == "Player 2")
            {
                if (Player1.Points > Player2.Points)
                {
                    MessageBox.Show(player1Name + " wins!");
                }
                else if (Player1.Points < Player2.Points)
                {
                    MessageBox.Show(player2Name + " wins!");
                }
                else if (Player1.Points == Player2.Points)
                {
                    MessageBox.Show("Draw!");
                }
            }
            if (player2Name == "Ai")
            {
                if (Player1.Points > ai.Points)
                {
                    MessageBox.Show(player1Name + " wins!");
                }
                else if (Player1.Points < ai.Points)
                {
                    MessageBox.Show(player2Name + " wins!");
                }
                else if (Player1.Points == ai.Points)
                {
                    MessageBox.Show("Draw!");
                }
            }
        } // CheckWhoWon
        public void SetDifficulty()
        {
            if (RB_Easy.Checked)
            {
                difficulty = Difficulty.Easy;
                TMR_AiMovement.Interval = 290;
            }
            if (RB_Normal.Checked)
            {
                difficulty = Difficulty.Normal;
                TMR_AiMovement.Interval = 190;
            }
            if (RB_Hard.Checked)
            {
                difficulty = Difficulty.Hard;
                TMR_AiMovement.Interval = 115;
            }
            LBL_Player2Points.ForeColor = Color.Black;
            ai.SetDifficulty(difficulty);
        } // SetDifficulty
        public void ResetEverything()
        {
            // locations
            Player1.SetLocation(0, 0);
            Player2.SetLocation(352, 352);
            ai.SetLocation(352, 352);
            food.SetLocation(176, 176);
            UpdateLocation(playerOneListBox, Player1.XLocation, Player1.YLocation);
            UpdateLocation(playerTwoListBox, Player2.XLocation, Player2.YLocation);

            // walls
            Controls.Remove(wallOnePlayer1ListBox);
            Controls.Remove(wallTwoPlayer1ListBox);
            Controls.Remove(wallOnePlayer2ListBox);
            Controls.Remove(wallTwoPlayer2ListBox);

            // time
            gameTime = constGameTime;
            LBL_Seconds.Text = Convert.ToString(gameTime);

            // points
            Player1.ResetPoints();
            Player2.ResetPoints();
            ai.ResetPoints();
            LBL_Player1Points.Text = "Player1: 0";
            LBL_Player2Points.Text = "Player2: 0";
        } // ResetEverything ******************** reset all ai extras

        // Nice
        public void UpdateLocation(ListBox listBox, int xLocation, int yLocation)
        {
            listBox.Location = new Point(xLocation, yLocation);
        }

        private void FRM_DinoGameWithClasses_MouseClick(object sender, MouseEventArgs e)
        {
            //food.SetLocation(352, 0);
            //UpdateLocation(foodListBox, food.XLocation, food.YLocation);
        }
    }
}
// Opdracht
/*
- maak 2 blokjes ipv dinos - DONE
- maak een grid waar ze op kunnen bewegen - DONE
- blokjes zijn bestuurbaar met toetsenbord - DONE
- blokjes kunnen allebei food oppakken, vervolgens spawned er een nieuwe - DONE
- score wordt apart bijgehouden - DONE
- je kunt niet samen op hetzelfde vakje staan, of uit het veld - DONE

extras
- new food spawnt op een eerlijke locatie - DONE
- timer maken ingame - DONE
- menu met informatie en start - DONE
- beide spelers kunnen 2 walls neerzetten - DONE
- een AI (die ook muren kan zetten) - WIP

BUGS
- ai can leave screen
- gametime timer keeps going down, at least stop updating it

Onnauwkeurigheden
- player2 object en ai object overlappen elkaar veel










// parts of thinking proces

Playing Field

1 O O O O O O O O 
O O O O O O O O O 
O O O O O O O O O 
O O O O O O O O O 
O O O O O O O O O 
O O O O O O O O O 
O O O O O O O O O 
O O O O O O O O O 
O O O O O O O O 2 
 

playing field
0,44,88,132,176,220,264,308,352

LOGIC: dont stand on same spot 
O O O O 
O O O O
O 1 O O
O 2 O O

1 (2,3)
2 (2,4)

player 2 up press
if (player1X == player2X && player2Y - player1Y != 1)

LOGIC: new food location 

O = good location
X = bad location

O O O O O O O O O 
O O O O O O O O O 
O X X X X X O O O 
O X X X X X O O O 
O X X 1 X X X X X 
O X X X X X X X X 
O X X X X X 2 X X 
O O O O X X X X X 
O O O O X X X X X 


new food location != 
p1x + 44 || +88 || -44 || -88
p2x + 44 || +88 || -44 || -88
p1y + 44 || +88 || -44 || -88
p2y + 44 || +88 || -44 || -88

LOGIC: Walls

wall = listbox

if (player makes wall && wallcount < 3)
{
    wall location = player location
    make wall visible
    other player collides with wall you dont
}
 */