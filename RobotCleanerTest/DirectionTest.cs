using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;

namespace RobotCleanerTest
{
    [TestClass]
    public class DirectionTest
    {
        [TestMethod]
        public void TestDirection()
        {
            Assert.AreEqual(Direction.GetDirection('E'), "EAST");
            Assert.AreEqual(Direction.GetDirection('W'), "WEST");
            Assert.AreEqual(Direction.GetDirection('N'), "NORTH");
            Assert.AreEqual(Direction.GetDirection('S'), "SOUTH");

            Assert.AreNotEqual(Direction.GetDirection('E'), "WEST");
            Assert.AreNotEqual(Direction.GetDirection('W'), "EAST");
            Assert.AreNotEqual(Direction.GetDirection('N'), "SOUTH");
            Assert.AreNotEqual(Direction.GetDirection('S'), "NORTH");

            Assert.AreEqual(Direction.GetDirection('A'), "INVALID");
        }
    }
}
