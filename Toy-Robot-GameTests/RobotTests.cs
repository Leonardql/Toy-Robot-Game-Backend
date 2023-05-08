using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toy_Robot_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game.Tests
{
    [TestClass()]
    public class RobotTests
    {
        [TestMethod()]
        public void IsFacingValidTest()
        {
            Robot robot = new Robot();

            Assert.AreEqual(robot.IsFacingValid("CENTER"), false);

            Assert.AreEqual(robot.IsFacingValid("NORTH"), true);
        }
    }
}