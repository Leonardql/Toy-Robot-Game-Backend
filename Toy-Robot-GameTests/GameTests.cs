﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod()]
        public void PlaceWallTest()
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);

            game.PlaceWall(2, 3);
            Assert.AreEqual(board.Square(2, 3), 2);
        }

        [TestMethod()]
        public void MoveTest()
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);

            game.PlaceRobot(1, 1, "NORTH");

            game.Move();

            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (1, 2, "NORTH"));

            game.PlaceRobot(1, 1, "SOUTH");

            game.Move();

            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (1, 5, "SOUTH"));
        }

        [TestMethod()]
        public void TurnTests()
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);

            game.PlaceRobot(1, 1, "NORTH");

            game.Left();

            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (1, 1, "WEST"));

            game.Right();

            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (1, 1, "NORTH"));


        }

        [TestMethod()]
        public void FirstGameTest()
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);

            game.PlaceRobot(3, 3, "NORTH");
            game.PlaceWall(3, 5);
            game.Move();
            game.Move();
            game.Right();
            game.Move();
            game.Move();
            game.Move();
            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (1,4, "EAST"));
        }


        [TestMethod()]
        public void SecondGameTeset()
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);

            game.PlaceRobot(2, 2, "WEST");
            game.PlaceWall(1, 1);
            game.PlaceWall(2, 2);
            game.PlaceWall(1, 3);
            game.Left();
            game.Left();
            game.Move();
            Assert.AreEqual((robot.Row, robot.Col, robot.Facing), (3, 2, "EAST"));
        }
    }
}