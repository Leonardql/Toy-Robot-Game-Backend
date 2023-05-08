using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game
{
    public class Game : ICommand
    {
        Board board;
        Robot robot;

        public Game(Board board, Robot robot)
        {
            this.board = board;
            this.robot = robot;
        }

        

        
        public void PlaceRobot(int row, int col, string facing)
        {
            throw new NotImplementedException();
        }

        public void PlaceWall(int row, int col)
        {
            throw new NotImplementedException();
        }

        public void Report()
        {
            throw new NotImplementedException();
        }


        public void Move()
        {
            throw new NotImplementedException();
        }


        public void Right()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }
    }
}
