using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RobotCleaner
{
    public class UserInput
    {

        List<string[]> mDirectionAndSteps = new List<string[]>();


        public void Start()
        {
            string number_of_inputs = Console.ReadLine();
            TakeInputFromUser(number_of_inputs);
            ExecuteProcess();
        }

        /*
         * 
         * Take input from user and add it in mDirectionAndSteps list
         *          
         */
        private void TakeInputFromUser(string number_of_inputs)
        {
            for (int i = 0; i < int.Parse(number_of_inputs) + 1; i++)
            {
                string[] lines = Regex.Split(Console.ReadLine(), " ");
                mDirectionAndSteps.Add(lines);
            }
        }


        /*
         * 
         * Check if given points are valid, If so then initilize environment and parse input
         * from list in form of direction and steps and start cleaning given map.
         * 
         */
        private void ExecuteProcess()
        {
            string[] lines = mDirectionAndSteps[0];
            int x = int.Parse(lines[0]);
            int y = int.Parse(lines[1]);

            if (IsValid(x, y))
            {
                RobotEnvironment environment = new RobotEnvironment(x, y);
                for (int i = 1; i < mDirectionAndSteps.Count(); i++)
                {
                    lines = mDirectionAndSteps[i];
                    char direction = char.Parse(lines[0].Trim());
                    int steps = int.Parse(lines[1]);

                    environment.StartCleaning(direction, steps);
                }
                Console.WriteLine("=> Cleaned: " + environment.GetUniquePoints());
            }
        }

         /** 
         * 
         * Check if robot is with in Map boundry return true otherwise false.
         * 
        **/
        public bool IsValid(int x, int y)
        {
            int boundry1 = RobotEnvironment.Map;
            int boundry2 = boundry1 * (-1);
            if ((x >= boundry2 && x <= boundry1) && (y >= boundry2 && y <= boundry1))
            {
                return true;
            }

            return false;
        }



    }
}
