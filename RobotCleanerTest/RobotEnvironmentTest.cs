using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;

namespace RobotCleanerTest
{
    [TestClass]
    public class RobotEnvironmentTest
    {
        [TestMethod]
        public void TestUniquePoints()
        {

            RobotEnvironment environment;
            
            int x = 10;
            int y = 22;
            environment = new RobotEnvironment(x, y);
            int requiredresult = 4;

            char direction = 'E';
            int steps = 2;
            environment.StartCleaning(direction, steps);

            direction = 'N';
            steps = 1;
            environment.StartCleaning(direction, steps);
            Assert.AreEqual(environment.GetUniquePoints(), requiredresult);



            environment = new RobotEnvironment(x, y);
            requiredresult = 36;

            direction = 'S';
            steps = 35;
            environment.StartCleaning(direction, steps);

            direction = 'N';
            steps = 30;
            environment.StartCleaning(direction, steps);
            Assert.AreEqual(environment.GetUniquePoints(), requiredresult); 

        }

        [TestMethod]
        public void TestBoundryLimits()
        {
            RobotEnvironment environment;

            int x = 0;
            int y = 0;
            environment = new RobotEnvironment(x, y);

            char direction = 'E';
            int steps = RobotEnvironment.Map + 25;
            int required = RobotEnvironment.Map + 1;

            environment.StartCleaning(direction, steps);
            int result = environment.GetUniquePoints();

            Assert.AreEqual(result, required);
        }



        [TestMethod]
        public void TestRobotStartingPoint()
        {
            bool result = false;
            RobotEnvironment environment;
            bool[,] mapdimension;

            int x = 0;
            int y = 0;

            environment = new  RobotEnvironment(x,y);
            mapdimension = environment.GetMapDim();
            result = mapdimension[RobotEnvironment.Map + x, RobotEnvironment.Map + y];
            Assert.IsTrue(result);

            x = -2;
            y = -4;
            environment = new RobotEnvironment(x,y);
            mapdimension = environment.GetMapDim();
            result = mapdimension[RobotEnvironment.Map + x, RobotEnvironment.Map + Math.Abs(y)];
            Assert.IsTrue(result);

            x = -4;
            y =  4;
            environment = new RobotEnvironment(x, y);
            mapdimension = environment.GetMapDim();
            result = mapdimension[RobotEnvironment.Map + x, RobotEnvironment.Map + Math.Abs(y)];
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestHeadEast()
        {
            int x = 0;
            int y = 0;
            int steps = 4;
            char direction = 'E';
            int requiredresult = 5;

            RobotEnvironment environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreEqual(environment.GetUniquePoints(), requiredresult);

            x = 0;
            y = 0;
            steps = 2;
            direction = 'E';
            requiredresult = 1;

            environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreNotEqual(environment.GetUniquePoints(), requiredresult);
        }


        [TestMethod]
        public void TestHeadWest()
        {
            int x = 0;
            int y = 0;
            int steps = 4;
            char direction = 'W';
            int requiredresult = 5;

            RobotEnvironment environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreEqual(environment.GetUniquePoints(), requiredresult);

            x = 0;
            y = 0;
            steps = 2;
            direction = 'W';
            requiredresult = 1;

            environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreNotEqual(environment.GetUniquePoints(), requiredresult);

        }

        [TestMethod]
        public void TestHeadNorth()
        {
            int x = 0;
            int y = 0;
            int steps = 4;
            char direction = 'N';
            int requiredresult = 5;

            RobotEnvironment environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreEqual(environment.GetUniquePoints(), requiredresult);

            x = 0;
            y = 0;
            steps = 2;
            direction = 'N';
            requiredresult = 1;

            environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreNotEqual(environment.GetUniquePoints(), requiredresult);

        }

        [TestMethod]
        public void TestHeadSouth()
        {
            int x = 0;
            int y = 0;
            int steps = 4;
            char direction = 'S';
            int requiredresult = 5;

            RobotEnvironment environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreEqual(environment.GetUniquePoints(), requiredresult);

            x = 0;
            y = 0;
            steps = 2;
            direction = 'S';
            requiredresult = 1;

            environment = new RobotEnvironment(x, y);
            environment.StartCleaning(direction, steps);
            Assert.AreNotEqual(environment.GetUniquePoints(), requiredresult);

        }
    }
}
