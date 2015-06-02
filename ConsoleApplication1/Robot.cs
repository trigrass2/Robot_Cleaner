using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCleaner
{
    public class Robot
    {
        int mXPos;
        int mYPos;

        public Robot()
        {}

        public Robot(int x, int y)
        {
            this.mXPos = x;
            this.mYPos = y;
        }

        public int GetXPosition() { return mXPos; }
        public int GetYPosition() { return mYPos; }

        public void SetXPosition(int x) { mXPos = x; }
        public void SetYPosition(int y) { mYPos = y; }
    
    }
}
