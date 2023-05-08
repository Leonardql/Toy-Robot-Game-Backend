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
    public class BoardTests
    {
        [TestMethod()]
        public void IsValidLocationTest()
        {
            Board board = new Board(5, 5);


            Assert.AreEqual(board.IsValidLocation(5, 6), false);
            Assert.AreEqual(board.IsValidLocation(1, 2), true);

        }

        [TestMethod()]
        public void IsEmptySquareTest()
        {

            Board board = new Board(5, 5);

            board.PlaceOnBoard(1, 2, 1);

            Assert.AreEqual(board.IsEmptySquare(1, 2), false);

            board.PlaceOnBoard(1, 2, 0);

            Assert.AreEqual(board.IsEmptySquare(1, 2), true);
        }

        

        [TestMethod()]
        public void PlaceOnBoardTest()
        {
            Board board = new Board(5, 5);

            board.PlaceOnBoard(1, 2, 1);

            Assert.AreEqual(board.Square(1, 2), 1);


        }
    }
}