using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoGame
{
    public partial class FRM_DinoGame : Form
    {

        System.Media.SoundPlayer music = new System.Media.SoundPlayer();

        public FRM_DinoGame()
        {
            InitializeComponent();
            music.SoundLocation = "Underclocked.wav";
        }

        //-----------//
        //--PLAYERS--//
        //-----------//

        // create players
        ListBox player1 = new ListBox();
        ListBox player2 = new ListBox();

        // create player locations
        static int xPlayer1Location = 0;
        static int yPlayer1Location = 0;
        static int xPlayer2Location = 352;
        static int yPlayer2Location = 352;

        // create a variable to count points
        static int player1points = 0;
        static int player2points = 0;

        //--------//
        //--FOOD--//
        //--------//

        // create food
        ListBox food = new ListBox();

        // create food location
        static int xFoodLocation = 176;
        static int yFoodLocation = 176;

        //---------//
        //--WALLS--//
        //---------//

        // create walls
        ListBox WallOnePlayer1 = new ListBox();
        ListBox WallTwoPlayer1 = new ListBox();
        ListBox WallOnePlayer2 = new ListBox();
        ListBox WallTwoPlayer2 = new ListBox();

        // create wall locations
        static int xWallOneLocationPlayer1;
        static int yWallOneLocationPlayer1;
        static int xWallTwoLocationPlayer1;
        static int yWallTwoLocationPlayer1;
        static int xWallOneLocationPlayer2;
        static int yWallOneLocationPlayer2;
        static int xWallTwoLocationPlayer2;
        static int yWallTwoLocationPlayer2;

        // create a variable that counts how many walls there
        static int WallCountPlayer1 = 0;
        static int WallCountPlayer2 = 0;

        //---------//
        //--TIMER--//
        //---------//

        // create timer
        static Timer myTimer = new Timer();

        // create variables for the timer
        static int gameTime = 60;
        static bool alwaysFalse = false;

        //---------//
        //--OTHER--//
        //---------//

        // create random
        Random foodLocationRng = new Random();

        // create bools to make statements easier to understand
        bool MultiplayerHasBegon = false;


        //--------//
        //--KEYS--//
        //--------//
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (MultiplayerHasBegon == true)
            {
                //--------------------//
                //--BUTTONS PLAYER 1--//
                //--------------------//

                // W (move up)
                if (keyData == Keys.W)
                {
                    // check if player collides with other player || check if player doesnt leave the screen
                    if (yPlayer1Location - yPlayer2Location == 44 && xPlayer1Location == xPlayer2Location || yPlayer1Location == 0)
                    {
                        // nothing
                    }
                    // check if player hits opponent wall
                    else if (yPlayer1Location - yWallOneLocationPlayer2 == 44 && xPlayer1Location == xWallOneLocationPlayer2 || yPlayer1Location - yWallTwoLocationPlayer2 == 44 && xPlayer1Location == xWallTwoLocationPlayer2)
                    {
                        // nothing
                    }
                    else
                    {
                        yPlayer1Location = yPlayer1Location - 44;
                    }
                }

                // A (move left)
                if (keyData == Keys.A)
                {
                    // check if player collides with other player || check if player doesnt leave the screen
                    if (xPlayer1Location - xPlayer2Location == 44 && yPlayer1Location == yPlayer2Location || xPlayer1Location == 0)
                    {
                        // nothing
                    }
                    // check if player hits wall
                    else if (xPlayer1Location - xWallOneLocationPlayer2 == 44 && yPlayer1Location == yWallOneLocationPlayer2 || xPlayer1Location - xWallTwoLocationPlayer2 == 44 && yPlayer1Location == yWallTwoLocationPlayer2)
                    { 
                        // nothing
                    }
                    else
                    {
                        xPlayer1Location = xPlayer1Location - 44;
                    }
                }

                // S (move down)
                if (keyData == Keys.S)
                {
                    // check if player collides with other player || check if player doesnt leave the screen
                    if (yPlayer2Location - yPlayer1Location == 44 && xPlayer1Location == xPlayer2Location || yPlayer1Location == 352)
                    {
                        // nothing
                    }
                    // check if player hits wall
                    else if (yWallOneLocationPlayer2 - yPlayer1Location == 44 && xPlayer1Location == xWallOneLocationPlayer2 || yWallTwoLocationPlayer2 - yPlayer1Location == 44 && xPlayer1Location == xWallTwoLocationPlayer2)
                    {
                        // nothing
                    }
                    else
                    {
                        yPlayer1Location = yPlayer1Location + 44;
                    }
                }

                // D (move right)
                if (keyData == Keys.D)
                {
                    // check if player collides with other player || check if player doesnt leave the screen
                    if (xPlayer2Location - xPlayer1Location == 44 && yPlayer1Location == yPlayer2Location || xPlayer1Location == 352)
                    {
                        // nothing
                    }
                    // check if player hits wall
                    else if (xWallOneLocationPlayer2 - xPlayer1Location == 44 && yPlayer1Location == yWallOneLocationPlayer2 || xWallTwoLocationPlayer2 - xPlayer1Location == 44 && yPlayer1Location == yWallTwoLocationPlayer2)
                    {
                        // nothing
                    }
                    else
                    {
                        xPlayer1Location = xPlayer1Location + 44;
                    }

                }

                // F (place block)
                if (keyData == Keys.F)
                {
                    // create first wall
                    if (WallCountPlayer1 == 0)
                    {
                        // save player location and give it to the wall
                        xWallOneLocationPlayer1 = xPlayer1Location;
                        yWallOneLocationPlayer1 = yPlayer1Location;

                        // give listbox values
                        WallOnePlayer1.Location = new System.Drawing.Point(xWallOneLocationPlayer1, yWallOneLocationPlayer1);
                        WallOnePlayer1.Size = new System.Drawing.Size(44, 44);
                        WallOnePlayer1.BackColor = System.Drawing.Color.DarkBlue;

                        // add listbox to form
                        Controls.Add(WallOnePlayer1);

                        // there is one wall placed
                        WallCountPlayer1++;
                    }
                    // create second wall
                    else if (WallCountPlayer1 == 1)
                    {
                        // save player location and give it to the wall
                        xWallTwoLocationPlayer1 = xPlayer1Location;
                        yWallTwoLocationPlayer1 = yPlayer1Location;

                        // give listbox values
                        WallTwoPlayer1.Location = new System.Drawing.Point(xWallTwoLocationPlayer1, yWallTwoLocationPlayer1);
                        WallTwoPlayer1.Size = new System.Drawing.Size(44, 44);
                        WallTwoPlayer1.BackColor = System.Drawing.Color.DarkBlue;

                        // add listbox to form
                        Controls.Add(WallTwoPlayer1);

                        // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                        WallCountPlayer1 = 0;
                    }
                }

                // playing field
                // 0,44,88,132,176,220,264,308,352

                //--------------------//
                //--BUTTONS PLAYER 2--//
                //--------------------//

                // NumPad8 (move up)
                if (keyData == Keys.NumPad8)
                {
                    // check if player collides with other player && check if player doesnt leave the screen
                    if (yPlayer2Location - yPlayer1Location == 44 && xPlayer1Location == xPlayer2Location || yPlayer2Location == 0)
                    {
                        // nothing
                    }
                    // check if player hits opponent wall
                    else if (yPlayer2Location - yWallOneLocationPlayer1 == 44 && xPlayer2Location == xWallOneLocationPlayer1 || yPlayer2Location - yWallTwoLocationPlayer1 == 44 && xPlayer2Location == xWallTwoLocationPlayer1)
                    {
                        // nothing
                    }
                    else
                    {
                        yPlayer2Location = yPlayer2Location - 44;
                    }
                }

                // NumPad4 (move left)
                if (keyData == Keys.NumPad4)
                {
                    // check if player collides with other player && check if player doesnt leave the screen
                    if (xPlayer2Location - xPlayer1Location == 44 && yPlayer1Location == yPlayer2Location || xPlayer2Location == 0)
                    {
                        // nothing
                    }
                    // check if player hits wall
                    else if (xPlayer2Location - xWallOneLocationPlayer1 == 44 && yPlayer2Location == yWallOneLocationPlayer1 || xPlayer2Location - xWallTwoLocationPlayer1 == 44 && yPlayer2Location == yWallTwoLocationPlayer1)
                    {
                        // nothing
                    }
                    else
                    {
                        xPlayer2Location = xPlayer2Location - 44;
                    }
                }

                // NumPad5 (move down)
                if (keyData == Keys.NumPad5)
                {
                    // check if player collides with other player && check if player doesnt leave the screen
                    if (yPlayer1Location - yPlayer2Location == 44 && xPlayer1Location == xPlayer2Location || yPlayer2Location == 352)
                    {
                        // nothing
                    }
                    // check if player hits wall
                    else if (yWallOneLocationPlayer1 - yPlayer2Location == 44 && xPlayer2Location == xWallOneLocationPlayer1 || yWallTwoLocationPlayer1 - yPlayer2Location == 44 && xPlayer2Location == xWallTwoLocationPlayer1)
                    {
                        // nothing
                    }
                    else
                    {
                        yPlayer2Location = yPlayer2Location + 44;
                    }
                }

                // NumPad6 (move right)
                if (keyData == Keys.NumPad6)
                {
                    // check if player collides with other player && check if player doesnt leave the screen
                    if (xPlayer1Location - xPlayer2Location == 44 && yPlayer1Location == yPlayer2Location || xPlayer2Location == 352)
                    {
                        // nothing
                    }
                    // check if player hits wall
                    else if (xWallOneLocationPlayer1 - xPlayer2Location == 44 && yPlayer2Location == yWallOneLocationPlayer1 || xWallTwoLocationPlayer1 - xPlayer2Location == 44 && yPlayer2Location == yWallTwoLocationPlayer1)
                    {
                        // nothing
                    }
                    else
                    {
                        xPlayer2Location = xPlayer2Location + 44;
                    }
                }

                // 0 (place block)
                if (keyData == Keys.NumPad0)
                {
                    // create first wall
                    if (WallCountPlayer2 == 0)
                    {
                        // save player location and give it to the wall
                        xWallOneLocationPlayer2 = xPlayer2Location;
                        yWallOneLocationPlayer2 = yPlayer2Location;

                        // give listbox values
                        WallOnePlayer2.Location = new System.Drawing.Point(xWallOneLocationPlayer2, yWallOneLocationPlayer2);
                        WallOnePlayer2.Size = new System.Drawing.Size(44, 44);
                        WallOnePlayer2.BackColor = System.Drawing.Color.DarkRed;

                        // add listbox to form
                        Controls.Add(WallOnePlayer2);

                        // there is one wall placed
                        WallCountPlayer2++;
                    }
                    // create second wall
                    else if (WallCountPlayer2 == 1)
                    {
                        // save player location and give it to the wall
                        xWallTwoLocationPlayer2 = xPlayer2Location;
                        yWallTwoLocationPlayer2 = yPlayer2Location;

                        // give listbox values
                        WallTwoPlayer2.Location = new System.Drawing.Point(xWallTwoLocationPlayer2, yWallTwoLocationPlayer2);
                        WallTwoPlayer2.Size = new System.Drawing.Size(44, 44);
                        WallTwoPlayer2.BackColor = System.Drawing.Color.DarkRed;

                        // add listbox to form
                        Controls.Add(WallTwoPlayer2);

                        // there are 2 walls now (max), if another wall will be placed the first one will be moved to the new location
                        WallCountPlayer2 = 0;
                    }
                }


                // update player locations
                player1.Location = new System.Drawing.Point(xPlayer1Location, yPlayer1Location);
                player2.Location = new System.Drawing.Point(xPlayer2Location, yPlayer2Location);

                // check if someone is on the food
                EatFood();

                // Give food and player locations with spacebar
                if (keyData == Keys.Delete)
                {
                    MessageBox.Show
                    (
                    "Player1: " + xPlayer1Location + " " + yPlayer1Location + Environment.NewLine +
                    "Player2: " + xPlayer2Location + " " + yPlayer2Location + Environment.NewLine +
                    "Food: " + xFoodLocation + " " + yFoodLocation
                    );
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        } // ProcessCmdKey


        //-----------//
        //--BUTTONS--//
        //-----------//
        private void BTN_SinglePlayer_Click(object sender, EventArgs e)
        {
            // player vs AI
        } // BTN_SinglePlayer

        private void BTN_Multiplayer_Click(object sender, EventArgs e)
        {
            // multiplayer has begon
            MultiplayerHasBegon = true;

            // make invisible
            GB_Mainscreen.Visible = !GB_Mainscreen.Visible;

            // make playing field visible
            PlayingfieldChangeVisibility();

            // play the music
            music.Play();

            // create the players
            CreatePlayers();

            // spawn the food
            SpawnFood();

            // start the game timer
            StartTimer();

        } // BTN_Multiplayer

        private void BTN_HowToPlay_Click(object sender, EventArgs e)
        {
            // make how to play visible
            GB_HowtoplayScreen.Visible = !GB_HowtoplayScreen.Visible;

            // make main menu invisible
            GB_Mainscreen.Visible = !GB_Mainscreen.Visible;
        } // BTN_HowToPlay

        private void BTN_Return_Click(object sender, EventArgs e)
        {
            // make main menu visible
            GB_Mainscreen.Visible = !GB_Mainscreen.Visible;

            // make how to play invisible
            GB_HowtoplayScreen.Visible = !GB_HowtoplayScreen.Visible;
        } // BTN_Return


        //-----------//
        //--METHODS--//
        //-----------//
        private void CreatePlayers()
        {
            // give listbox values
            player1.Location = new System.Drawing.Point(xPlayer1Location, yPlayer1Location);
            player1.Size = new System.Drawing.Size(44, 44);
            player1.BackColor = System.Drawing.Color.Blue;

            // add listbox to form
            Controls.Add(player1);

            // give listbox values
            player2.Location = new System.Drawing.Point(xPlayer2Location, yPlayer2Location);
            player2.Size = new System.Drawing.Size(44, 44);
            player2.BackColor = System.Drawing.Color.Red;

            // add listbox to form
            Controls.Add(player2);

        } // CreatePlayers

        private void SpawnFood()
        {
            // give listbox values
            food.Location = new System.Drawing.Point(xFoodLocation, yFoodLocation);
            food.Size = new System.Drawing.Size(44, 44);
            food.BackColor = System.Drawing.Color.MediumPurple;

            // add listbox to form
            Controls.Add(food);
        } // SpawnFood

        private void EatFood()
        {
            // check if someone ate food
            if (xPlayer1Location == xFoodLocation && yPlayer1Location == yFoodLocation || xPlayer2Location == xFoodLocation && yPlayer2Location == yFoodLocation)
            {
                // check who ate food
                if (xPlayer1Location == xFoodLocation && yPlayer1Location == yFoodLocation)
                {
                    // remove food
                    Controls.Remove(food);

                    // give point to player 1
                    player1points++;
                    LBL_Player1Points.Text = "Player1: " + player1points;
                }
                if (xPlayer2Location == xFoodLocation && yPlayer2Location == yFoodLocation)
                {
                    // remove food

                    Controls.Remove(food);
                    // give point to player 2
                    player2points++;
                    LBL_Player2Points.Text = "Player2: " + player2points;
                }

                // spawn new food
                NewFoodLocation();
                SpawnFood();
            }
        } // EatFood

        private void NewFoodLocation()
        {
            //     X-waarden                                                                                                                                                                                                                             Y-waarden||                                                                                                                                                                                                                                           Walls||
            //     niet zelfde x als player 1,       || niet zelfde x als player 2        || niet rechts van player 1               || niet links van player 1                || niet rechts van player 2               || niet links van player 2                || niet zelfde y als player 1,       || niet zelfde y als player 2,       || niet onder van player 1                || niet boven van player 1                || niet onder  van player 2               || niet boven van player 2                || 
            while (xFoodLocation == xPlayer1Location || xFoodLocation == xPlayer2Location || xFoodLocation == xPlayer1Location + 44 || xFoodLocation == xPlayer1Location - 44 || xFoodLocation == xPlayer2Location + 44 || xFoodLocation == xPlayer2Location - 44 || yFoodLocation == yPlayer1Location || yFoodLocation == yPlayer2Location || yFoodLocation == yPlayer1Location + 44 || yFoodLocation == yPlayer1Location - 44 || yFoodLocation == yPlayer2Location + 44 || yFoodLocation == yPlayer2Location - 44 || food.Location == WallOnePlayer1.Location || food.Location == WallTwoPlayer1.Location || food.Location == WallOnePlayer2.Location || food.Location == WallTwoPlayer2.Location)
            {
                xFoodLocation = foodLocationRng.Next(0, 9);
                xFoodLocation = xFoodLocation * 44;
                yFoodLocation = foodLocationRng.Next(0, 9);
                yFoodLocation = yFoodLocation * 44;
                food.Location = new System.Drawing.Point(xFoodLocation, yFoodLocation);
            }

            /*

            oke dus stel dat

            O O O O O O O O O 
            O O O O O O O O O 
            O O O O 1 O O O O 
            O O O O O O O O O 
            O O O O O O O O O 
            O O O O O O O O O 
            O O O O O O 2 O O 
            O O O O O O O O O 
            O O O O O O O O O

            1(5, 7)
            2(7, 3)

            dus deze spawns worden voorkomen

            O O O X X X X X O 
            X X X X X X X X X 
            X X X X 1 X X X X 
            X X X X X X X X X 
            O O O X X X X X O 
            X X X X X X X X X 
            X X X X X X 2 X X 
            X X X X X X X X X 
            O O O X X X X X O

            er blijven altijd minimaal 9 spawns open en max 42

            */


        } // NewFoodLocation

        private void TMR_GameTime(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();

            // increments the counter
            gameTime--;
            LBL_Seconds.Text = Convert.ToString(gameTime);

            // timer continues
            if (gameTime != 0)
            {
                myTimer.Enabled = true;
            }
            // timer stops
            else
            {
                // game stops
                MultiplayerHasBegon = false;

                // check who won
                CheckWhoWon();

                // reset locations and positions
                ResetLocationsAndPoints();

                // events don't happen anymore if timer ticks
                myTimer.Tick -= new EventHandler(TMR_GameTime);

                // reset gametime
                gameTime = 60;
                LBL_Seconds.Text = Convert.ToString(gameTime);

                // make main menu visible
                GB_Mainscreen.Visible = !GB_Mainscreen.Visible;
            }
        } // TimerEventProcessor

        private void StartTimer()
        {
            // events happen if timer ticks
            myTimer.Tick += new EventHandler(TMR_GameTime);

            // Sets the timer interval to 1 seconds.
            myTimer.Interval = 1000;
            myTimer.Start();

            // Runs the timer, and raises the event.
            while (alwaysFalse == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }
        } // StartTimer

        private void PlayingfieldChangeVisibility()
        {
            LBL_Player1Points.Visible = !LBL_Player1Points.Visible;
            LBL_Player2Points.Visible = !LBL_Player2Points.Visible;
            LBL_Seconds.Visible = !LBL_Seconds.Visible;
            LBL_Time.Visible = !LBL_Time.Visible;
        } // PlayingfieldChangeVisibility

        private void ResetLocationsAndPoints()
        {
            // reset locations
            xPlayer1Location = 0;
            yPlayer1Location = 0;
            xPlayer2Location = 352;
            yPlayer2Location = 352;
            xFoodLocation = 176;
            yFoodLocation = 176;

            // reset points
            player1points = 0;
            LBL_Player1Points.Text = "Player1: " + player1points;
            player2points = 0;
            LBL_Player2Points.Text = "Player2: " + player2points;
        } // ResetLocations

        private void CheckWhoWon()
        {
            if (player1points > player2points)
            {
                MessageBox.Show("Player 1 wins!");
            }
            else if (player1points < player2points)
            {
                MessageBox.Show("Player 2 wins!");
            }
            else if (player1points == player2points)
            {
                MessageBox.Show("Draw!");
            }
        } // CheckWhoWon
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
- een AI
- aantal food zelf aanpassen
- tijd zelf aanpassen

BUGS
- schermen staan niet op elkaar

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