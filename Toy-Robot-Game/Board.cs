using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game
{
    public class Board
    {
        private int rows;
        private int cols;
        private int[,] board;

        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }

        public Board(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            board = new int[rows + 1, cols + 1];
        }

        public bool IsValidLocation(int row, int col)
        {
            if (row < 0 || col < 0 || row > Rows || col > Cols)
            {
                Console.WriteLine(" This command is ignored because the COL or ROW coordinate is invalid");
                return false;
            }
            return true;
        }

        // places objectnr on the square:
        // 0 = empty square
        // 1 = robot
        // 2 = wall
        public void PlaceOnBoard(int row, int col, int objectNr)
        {
            board[row, col] = objectNr;
        }

       

        public int Square(int row, int col)
        {
            return board[row,col];
        }

        public bool IsEmptySquare(int row, int col)
        {
            if (Square(row,col) == 0)
            {
                return true;
            }
            if (Square(row, col) == 1)
            {
                Console.WriteLine("There is a Robot on that square");
                return false;
            }

            if (Square(row, col) == 2)
            {
                Console.WriteLine("There is a wall on that square");
                return false;
            }

            return false;
        }




    }
}
