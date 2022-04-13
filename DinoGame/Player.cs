using System;
using System.Collections.Generic;
using System.Text;

namespace DinoGameWithClasses
{
    class Player
    {
        // Fields
        int xLocation = 0;
        int yLocation = 0;
        int points = 0;
        int wallCount = 0;
        bool changeUpKey = false;
        bool changeLeftKey = false;
        bool changeDownKey = false;
        bool changeRightKey = false;
        bool changeWallKey = false;

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int Points { get { return points; } }
        public int WallCount { get { return wallCount; } }
        public bool ChangeUpKey { get { return changeUpKey; } }
        public bool ChangeLeftKey { get { return changeLeftKey; } }
        public bool ChangeDownKey { get { return changeDownKey; } }
        public bool ChangeRightKey { get { return changeRightKey; } }
        public bool ChangeWallKey { get { return changeWallKey; } }

        // Methods
        public void ModifyChangeUpKey(bool status)
        {
            changeUpKey = status;
        }
        public void ModifyChangeLeftKey(bool status)
        {
            changeLeftKey = status;
        }
        public void ModifyChangeDownKey(bool status)
        {
            changeDownKey = status;
        }
        public void ModifyChangeRightKey(bool status)
        {
            changeRightKey = status;
        }
        public void ModifyChangeWallKey(bool status)
        {
            changeWallKey = status;
        }

        public void AddPointToScore()
        {
            points++;
        }
        public void ResetPoints()
        {
            points = 0;
        }
        public void Modifylocation(int xModifier, int yModifier)
        {
            xLocation = xLocation + xModifier;
            yLocation = yLocation + yModifier;
        }
        public void ModifyWallCount(int num)
        {
            wallCount = wallCount + num;
        }
        public void SetLocation(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }

        public void MoveUp(int xOtherPlayerLocation, int yOtherPlayerLocation, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            // check if player collides with other player || check if player doesnt leave the screen
            if (YLocation - yOtherPlayerLocation == 44 && XLocation == xOtherPlayerLocation || YLocation == 0)
            {
                // nothing
            }
            // check if player hits opponent wall
            else if (YLocation - yWallOne == 44 && XLocation == xWallOne || YLocation - yWallTwo == 44 && XLocation == xWallTwo)
            {
                // nothing
            }
            else
            {
                Modifylocation(0, -44);
            }
        }
        public void MoveRight(int xOtherPlayerLocation, int yOtherPlayerLocation, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            // check if player collides with other player || check if player doesnt leave the screen
            if (xOtherPlayerLocation - XLocation == 44 && YLocation == yOtherPlayerLocation || XLocation == 352)
            {
                // nothing
            }
            // check if player hits wall
            else if (xWallOne - XLocation == 44 && YLocation == yWallOne || xWallTwo - XLocation == 44 && YLocation == yWallTwo)
            {
                // nothing
            }
            else
            {
                Modifylocation(44, 0);
            }
        }
        public void MoveDown(int xOtherPlayerLocation, int yOtherPlayerLocation, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            // check if player collides with other player || check if player doesnt leave the screen
            if (yOtherPlayerLocation - YLocation == 44 && XLocation == xOtherPlayerLocation || YLocation == 352)
            {
                // nothing
            }
            // check if player hits wall
            else if (yWallOne - YLocation == 44 && XLocation == xWallOne || yWallTwo - YLocation == 44 && XLocation == xWallTwo)
            {
                // nothing
            }
            else
            {
                Modifylocation(0, 44);
            }
        }
        public void MoveLeft(int xOtherPlayerLocation, int yOtherPlayerLocation, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            // check if player collides with other player || check if player doesnt leave the screen
            if (XLocation - xOtherPlayerLocation == 44 && YLocation == yOtherPlayerLocation || XLocation == 0)
            {
                // nothing
            }
            // check if player hits wall
            else if (XLocation - xWallOne == 44 && YLocation == yWallOne || XLocation - xWallTwo == 44 && YLocation == yWallTwo)
            {
                // nothing
            }
            else
            {
                Modifylocation(-44, 0);
            }
        }
    }
}
