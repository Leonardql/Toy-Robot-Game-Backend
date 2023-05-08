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
    public class GameTests
    {
        [TestMethod()]
        public void PlaceRobotTest()
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);

            game.PlaceRobot(2, 3, "NORTH");

            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (2, 3, "NORTH"));
        }
    }
}