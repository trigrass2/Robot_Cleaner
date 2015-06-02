using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;

namespace RobotCleanerTest
{
    [TestClass]
    public class RobotTest
    {
        
        [TestMethod]
        public void TestGetSet()
        {
            Robot robot = new Robot();
            
            int xposition = 10;
            int yposition = 20;
            
            robot.SetXPosition(xposition);
            robot.SetYPosition(yposition);

            Assert.AreEqual(robot.GetXPosition(), xposition);
            Assert.AreEqual(robot.GetYPosition(), yposition);

            int invalidposition = 25;

            Assert.AreNotEqual(robot.GetXPosition(), invalidposition);
            Assert.AreNotEqual(robot.GetYPosition(), invalidposition);
        }
        
        
        [TestMethod]
        public void TestRobotConstructor()
        {
            int xposition = 5;
            int yposition = -5;

            Robot robot = new Robot(xposition,yposition);

            Assert.AreEqual(robot.GetXPosition(), xposition);
            Assert.AreEqual(robot.GetYPosition(), yposition);
        }
    }
}
