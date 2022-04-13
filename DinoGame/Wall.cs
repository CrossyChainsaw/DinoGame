using System;
using System.Collections.Generic;
using System.Text;

namespace DinoGameWithClasses
{
    class Wall
    {
        // Fields
        int xLocation = -44;
        int yLocation = -44;

        // Properties
        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }

        // Methods
        public void ChangeXLocation(int num)
        {
            xLocation = num;
        }
        public void ChangeYLocation(int num)
        {
            yLocation = num;
        }
        public void SaveLocation(int x, int y)
        {
            xLocation = x;
            yLocation = y;
        }
    }
}
