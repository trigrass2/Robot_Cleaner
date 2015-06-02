using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCleaner;

namespace RobotCleanerTest
{
    [TestClass]
    public class UserInputTest
    {
        [TestMethod]
        public void TestIsValid()
        {
            UserInput userinput = new UserInput();
            
            Assert.IsTrue(userinput.IsValid(10,10));
            Assert.IsFalse(userinput.IsValid(RobotEnvironment.Map + 25, 10));
        }
    }
}
