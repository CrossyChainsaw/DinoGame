using System;
using System.Collections.Generic;
using System.Text;

namespace DinoGameWithClasses
{
    enum BlockedDirection
    {
        None,
        Right,
        Left,
        Down,
        Up
    }
    enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }
    enum CornerBlockCorner
    {
        None,
        UpLeft,
        UpRight,
        DownRight,
        DownLeft
    }

    class AI
    {
        // Fields
        int xLocation = 0;
        int yLocation = 0;
        int points = 0;
        int wallCount = 0;
        int movementSpeed = 44;
        bool placeWall = false;
        bool movingToCorner = true;
        BlockedDirection blockedDirection = new BlockedDirection();
        Difficulty difficulty = new Difficulty();
        CornerBlockCorner cornerBlockCorner = new CornerBlockCorner();

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public int Points { get { return points; } }
        public int WallCount { get { return wallCount; } }
        public bool PlaceWall { get { return placeWall; } }


        public void AiMovement(int xFood, int yFood, int xPlayer, int yPlayer, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo, int playerPoints)
        {
            // hunt food
            if (cornerBlockCorner != CornerBlockCorner.UpLeft && cornerBlockCorner != CornerBlockCorner.UpRight && cornerBlockCorner != CornerBlockCorner.DownRight && cornerBlockCorner != CornerBlockCorner.DownLeft)
            {
                if (xLocation < xFood)
                {
                    MoveRight(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
                else if (xLocation > xFood)
                {
                    MoveLeft(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
                else if (yLocation < yFood)
                {
                    MoveDown(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
                else if (yLocation > yFood)
                {
                    MoveUp(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
            }
            // move arround a wall if ai is blocked
            if (difficulty != Difficulty.Easy) // easy ai is dom en kan dit niet
            {
                if (blockedDirection == BlockedDirection.Right)
                {
                    if (yLocation < yPlayer)
                    {
                        MoveDown(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    else if (yLocation >= yPlayer)
                    {
                        MoveUp(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    MoveRight(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
                if (blockedDirection == BlockedDirection.Left)
                {
                    if (yLocation < yPlayer)
                    {
                        MoveDown(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    else if (yLocation >= yPlayer)
                    {
                        MoveUp(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    MoveLeft(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
                if (blockedDirection == BlockedDirection.Up)
                {
                    if (xLocation < xPlayer)
                    {
                        MoveRight(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    else if (xLocation >= xPlayer)
                    {
                        MoveLeft(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    MoveUp(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
                if (blockedDirection == BlockedDirection.Down)
                {
                    if (xLocation < xPlayer)
                    {
                        MoveRight(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    else if (xLocation >= xPlayer)
                    {
                        MoveLeft(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                    }
                    MoveDown(xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
                }
            }
            // cornerblock
            if (points > playerPoints && difficulty == Difficulty.Hard)
            {
                CornerBlock(xFood, yFood, xPlayer, yPlayer, xWallOne, yWallOne, xWallTwo, yWallTwo);
            }
            else
            {
                cornerBlockCorner = CornerBlockCorner.None;
            }
        }
        public void CornerBlock(int xFood, int yFood, int xPlayer, int yPlayer, int xWallOnePlayerOne, int yWallOnePlayerOne, int xWallTwoPlayerOne, int yWallTwoPlayerOne)
        {
            if (xFood == 0 && yFood == 0 || xFood == 0 && yFood == 44 || xFood == 44 && yFood == 0)
            {
                cornerBlockCorner = CornerBlockCorner.UpLeft;

                // if at (0, 88) start corner blocking
                if (xLocation == 0 && yLocation == 88)
                {
                    placeWall = true;
                    MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    movingToCorner = false;
                }
                else if (xLocation == 44 && yLocation == 44)
                {
                    MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                }

                // move to (0, 88)
                if (movingToCorner)
                {
                    if (xLocation > 0)
                    {
                        MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (yLocation > 88)
                    {
                        MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (yLocation < 88)
                    {
                        MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    placeWall = true;
                }
            }
            else if (cornerBlockCorner == CornerBlockCorner.UpLeft)
            {
                // cornerblock failed, continue playing
                cornerBlockCorner = CornerBlockCorner.None;
                movingToCorner = true;
            }
            
            if (xFood == 352 && yFood == 0 || xFood == 308 && yFood == 0 || xFood == 352 && yFood == 44)
            {
                cornerBlockCorner = CornerBlockCorner.UpRight;

                // if at (264, 0) start corner blocking
                if (xLocation == 264 && yLocation == 0)
                {
                    placeWall = true;
                    MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    movingToCorner = false;
                }
                else if (xLocation == 308 && yLocation == 44)
                {
                    MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                }

                // move to (264, 0)
                if (movingToCorner)
                {
                    if (xLocation < 264)
                    {
                        MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (xLocation > 264)
                    {
                        MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (yLocation > 0)
                    {
                        MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    placeWall = true;
                }
            }
            else if (cornerBlockCorner == CornerBlockCorner.UpRight)
            {
                // cornerblock failed, continue playing
                cornerBlockCorner = CornerBlockCorner.None;
                movingToCorner = true;
            }

            if (xFood == 352 && yFood == 352 || xFood == 352 && yFood == 308 || xFood == 308 && yFood == 352)
            {
                cornerBlockCorner = CornerBlockCorner.DownRight;

                // if at (352, 264) start corner blocking
                if (xLocation == 352 && yLocation == 264)
                {
                    placeWall = true;
                    MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    movingToCorner = false;
                }
                else if (xLocation == 308 && yLocation == 308)
                {
                    MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                }

                // move to (352, 264)
                if (movingToCorner)
                {
                    if (xLocation < 352)
                    {
                        MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (yLocation > 264)
                    {
                        MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (yLocation < 264)
                    {
                        MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    placeWall = true;
                }
            }
            else if (cornerBlockCorner == CornerBlockCorner.DownRight)
            {
                // cornerblock failed, continue playing
                cornerBlockCorner = CornerBlockCorner.None;
                movingToCorner = true;
            }

            if (xFood == 0 && yFood == 308 || xFood == 0 && yFood == 352 || xFood == 44 && yFood == 352)
            {
                cornerBlockCorner = CornerBlockCorner.DownLeft;

                // if at (88, 352) start corner blocking
                if (xLocation == 352 && yLocation == 264)
                {
                    placeWall = true;
                    MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    movingToCorner = false;
                }
                else if (xLocation == 308 && yLocation == 308)
                {
                    MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    MoveUp(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                }

                // move to (88, 352)
                if (movingToCorner)
                {
                    if (xLocation < 88)
                    {
                        MoveRight(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (xLocation > 88)
                    {
                        MoveLeft(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    if (yLocation < 352)
                    {
                        MoveDown(xPlayer, yPlayer, xWallOnePlayerOne, yWallOnePlayerOne, xWallTwoPlayerOne, yWallTwoPlayerOne);
                    }
                    placeWall = true;
                }
            }
            else if (cornerBlockCorner == CornerBlockCorner.DownLeft)
            {
                // cornerblock failed, continue playing
                cornerBlockCorner = CornerBlockCorner.None;
                movingToCorner = true;
            }
        }

        public void MoveUp(int xPlayer, int yPlayer, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            if (yLocation - movementSpeed == yPlayer && xLocation == xPlayer)
            {
                // blocked by player
                blockedDirection = BlockedDirection.Up;
            }
            else if (yLocation - movementSpeed == yWallOne && xLocation == xWallOne || yLocation - movementSpeed == yWallTwo && xLocation == xWallTwo)
            {
                blockedDirection = BlockedDirection.Up;
            }
            else
            {
                yLocation = yLocation - movementSpeed;
                blockedDirection = BlockedDirection.None;
            }
        }
        public void MoveRight(int xPlayer, int yPlayer, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            if (xLocation + movementSpeed == xPlayer && yLocation == yPlayer)
            {
                // blocked by player
                blockedDirection = BlockedDirection.Right;
            }
            else if (xLocation + movementSpeed == xWallOne && yLocation == yWallOne || xLocation + movementSpeed == xWallTwo && yLocation == yWallTwo)
            {
                // blocked by wall
                // move arrouind wall
                blockedDirection = BlockedDirection.Right;
            }
            else
            {
                xLocation = xLocation + movementSpeed;
                blockedDirection = BlockedDirection.None;
            }
        }
        public void MoveDown(int xPlayer, int yPlayer, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            if (yLocation + movementSpeed == yPlayer && xLocation == xPlayer)
            {
                // blocked by player
                blockedDirection = BlockedDirection.Down;
            }
            else if (yLocation + movementSpeed == yWallOne && xLocation == xWallOne || yLocation + movementSpeed == yWallTwo && xLocation == xWallTwo)
            {
                // blocked by wall
                // move arrouind wall
                blockedDirection = BlockedDirection.Down;
            }
            else
            {
                yLocation = yLocation + movementSpeed;
                blockedDirection = BlockedDirection.None;
            }
        }
        public void MoveLeft(int xPlayer, int yPlayer, int xWallOne, int yWallOne, int xWallTwo, int yWallTwo)
        {
            if (xLocation - movementSpeed == xPlayer && yLocation == yPlayer)
            {
                // blocked by player
                blockedDirection = BlockedDirection.Left;
            }
            else if (xLocation - movementSpeed == xWallOne && yLocation == yWallOne || xLocation - movementSpeed == xWallTwo && yLocation == yWallTwo)
            {
                // blocked by wall
                // move arrouind wall
                blockedDirection = BlockedDirection.Left;
            }
            else
            {
                xLocation = xLocation - movementSpeed;
                blockedDirection = BlockedDirection.None;
            }
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
        public void SetDifficulty(Difficulty RB_Difficulty)
        {
            difficulty = RB_Difficulty;
        }
        public void SetLocation(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }
        public bool BuildWallAlgorithm(int xFood, int yFood, int xPlayer, int yPlayer)
        {
            if (cornerBlockCorner != CornerBlockCorner.UpLeft && cornerBlockCorner != CornerBlockCorner.UpRight && cornerBlockCorner != CornerBlockCorner.DownRight && cornerBlockCorner != CornerBlockCorner.DownLeft)
            {
                if (difficulty == Difficulty.Normal)
                {
                    if (xLocation == xFood && yLocation == yFood)
                    {
                        return true;
                    }
                    if (xLocation == xPlayer || yLocation == yPlayer)
                    {
                        return true;
                    }
                }
                if (difficulty == Difficulty.Hard)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PlaceWallMethod()
        {
            if (placeWall)
            {
                return true;
            }
            return false;
        }

        public void MakePlaceWallFalse()
        {
            placeWall = false;
        }
    }
}
