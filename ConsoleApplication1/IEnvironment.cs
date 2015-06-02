using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCleaner
{
    interface IEnvironment
    {
         void HeadEast  (int steps);
         void HeadWest  (int steps);
         void HeadNorth (int steps);
         void HeadSouth (int steps);

         void CleanDirt();
         bool IsClean();
         void AddUniquePoints();
         int GetUniquePoints();
         void CalculateRobotStatringPoint(int x, int y);
         void StartCleaning(char c, int step);

         bool[,] GetMapDim();
       
    }
}
