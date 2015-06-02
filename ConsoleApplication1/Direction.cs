using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCleaner
{
    public class Direction
    {
        public static char NORTH    = 'N';
        public static char EAST     = 'E';
        public static char WEST     = 'W';
        public static char SOUTH    = 'S';
       
        public static String GetDirection(char direction)
        {
            if (direction == NORTH)     return "NORTH";
            if (direction == EAST)      return "EAST";
            if (direction == SOUTH)     return "SOUTH";
            if (direction == WEST)      return "WEST";

            return "INVALID";
        }

    }
}
