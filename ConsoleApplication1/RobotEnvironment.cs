using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCleaner
{
    public class RobotEnvironment : IEnvironment
    {
        public static int Map = 5000;

        private static int x_axis = Map * 2 + 1;
        private static int y_axis = Map * 2 + 1;

        private int mUniquePoints;
        private bool[,] mMapDimensions;
        Robot mRobot;

        
        public RobotEnvironment()
        {

        }

        /**
        * Construcor 
        * initilize Map, set Robot starting point.
        */
        public RobotEnvironment(int x, int y)
        {
            mUniquePoints = 0;
            mMapDimensions = new bool[x_axis, y_axis];
            CalculateRobotStatringPoint(x, y);
        }

        public void CalculateRobotStatringPoint(int x, int y) 
        {
            int m = Map;
            x = m + x;

            if (y < 0)
                y = m + Math.Abs(y);
            else
                y = m + (y * -1);

            mRobot = new Robot(x, y);
            CleanDirt(); // Clean starting point
        }

        /**
         * Move Left
         */
        public void HeadEast(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (mRobot.GetXPosition() == (0)) break;

                mRobot.SetXPosition(mRobot.GetXPosition() - 1);
                if (!IsClean())
                {
                    CleanDirt(); 
                }
            }
        }

        /*
        * Move Right
        */
        public void HeadWest(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (mRobot.GetXPosition() == (Map * 2)) break;

                mRobot.SetXPosition(mRobot.GetXPosition() + 1);
                if (!IsClean())
                {
                    CleanDirt();
                }
            }
        }
        

        /*
         * Move Up
         */
        public void HeadNorth(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (mRobot.GetYPosition() == 0) break;

                mRobot.SetYPosition(mRobot.GetYPosition() - 1);
                if (!IsClean())
                {
                    CleanDirt();
                }
            }
        }
        
        /*
         * Move Down
         */
        public void HeadSouth(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (mRobot.GetYPosition() == (Map * 2)) break;

                mRobot.SetYPosition(mRobot.GetYPosition() + 1);
                if (!IsClean())
                {
                    CleanDirt();
                }
            }
        }


        /**
         * 
         * Takes Robot direction and Steps and call the appropriate function.
         * 
         */
        public void StartCleaning(char direction, int steps)
        {
            if (direction == Direction.NORTH)
            {
                HeadNorth(steps);
                return ;
            }
                    
            if (direction == Direction.EAST)
            {
                HeadEast(steps);
                return ;
            }
           
            if (direction == Direction.SOUTH)
            {
                HeadSouth(steps);
                return;
            }
           
            if (direction == Direction.WEST)
            {
                HeadWest(steps);
                return;
            }            
        }

        public bool[,] GetMapDim()
        {
            return mMapDimensions;
        }

        /**
         * Check if place is already clean. Return True, False otherwise
         */
        public bool IsClean()
        {
            int x = mRobot.GetXPosition();
            int y = mRobot.GetYPosition();

            return mMapDimensions[x,y];
        }

        /**
        * Fetch the current robot current location and clean it by setting value to True.
        * increment in unique clean points.
        */
        public void CleanDirt()
        {
            int x = mRobot.GetXPosition();
            int y = mRobot.GetYPosition();
            mMapDimensions[x, y] = true;
            AddUniquePoints();
        }


        public void AddUniquePoints()
        {
            mUniquePoints++;
        }

        /*
         * Get clean unique points.
         */
        public int GetUniquePoints()
        {
            return mUniquePoints;
        }
    }
}
