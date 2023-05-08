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

        public Board(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            board = new int[rows + 1, cols + 1];
        }


    }
}
