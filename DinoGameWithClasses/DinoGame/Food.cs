using System;
using System.Collections.Generic;
using System.Text;

namespace DinoGameWithClasses
{
    class Food
    {
        // Fields
        int xLocation = 176;
        int yLocation = 176;

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }

        // Methods
        public void FilterGoodLocation(Random rnd, int xPlayer1Location, int yPlayer1Location, int xPlayer2Location, int yPlayer2Location, int xWallOnePlayer1, int yWallOnePlayer1, int xWallTwoPlayer1, int yWallTwoPlayer1, int xWallOnePlayer2, int yWallOnePlayer2, int xWallTwoPlayer2, int yWallTwoPlayer2)
        {
            // als alles false is is het een goede locatie
            while (NotOnOrAroundPlayer(xPlayer1Location, yPlayer1Location) || NotOnOrAroundPlayer(xPlayer2Location, yPlayer2Location) || NotOnWall(xWallOnePlayer1, yWallOnePlayer1) || NotOnWall(xWallTwoPlayer1, yWallTwoPlayer1) || NotOnWall(xWallOnePlayer2, yWallOnePlayer2) || NotOnWall(xWallTwoPlayer2, yWallTwoPlayer2))
            {
                xLocation = rnd.Next(0, 9);
                xLocation = xLocation * 44;
                yLocation = rnd.Next(0, 9);
                yLocation = yLocation * 44;
            }
        }
        public bool NotOnOrAroundPlayer(int xPlayer, int yPlayer)
        {
            bool onPlayer = false;
            bool abovePlayer = false;
            bool rightPlayer = false;
            bool underPlayer = false;
            bool leftPlayer = false;
            bool uprightPlayer = false;
            bool downrightPlayer = false;
            bool downleftPlayer = false;
            bool upleftPlayer = false;

            // on player
            if (xLocation == xPlayer && yLocation == yPlayer)
            {
                onPlayer = true;
            }
            // up, right, down, left from player
            if (yLocation == yPlayer - 44 && xLocation == xPlayer)
            {
                abovePlayer = true;
            }
            if (xLocation == xPlayer + 44 && yLocation == yPlayer)
            {
                rightPlayer = true;
            }
            if (yLocation == yPlayer + 44 && xLocation == xPlayer)
            {
                underPlayer = true;
            }
            if (xLocation == xPlayer - 44 && yLocation == yPlayer)
            {
                leftPlayer = true;
            }
            // upright, downright, downleft, upleft from player 
            if (yLocation == yPlayer - 44 && xLocation == xPlayer + 44)
            {
                uprightPlayer = true;
            }
            if (yLocation == yPlayer + 44 && xLocation == xPlayer + 44)
            {
                downrightPlayer = true;
            }
            if (yLocation == yPlayer - +44 && xLocation == xPlayer - 44)
            {
                downleftPlayer = true;
            }
            if (yLocation == yPlayer - 44 && xLocation == xPlayer - 44)
            {
                upleftPlayer = false;
            }

            if (onPlayer || abovePlayer || rightPlayer || underPlayer || leftPlayer || uprightPlayer || downrightPlayer || downleftPlayer || upleftPlayer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NotOnWall(int xWall, int yWall)
        {
            if (xLocation == xWall && yLocation == yWall)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetLocation(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }
    }
}