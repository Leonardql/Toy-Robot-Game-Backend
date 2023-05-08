using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game
{
    internal interface ICommand
    {
        public void PlaceRobot(int row, int col, string facing);

        public void PlaceWall(int row, int col);

        public void Report();
        public void Move();

        public void Left();

        public void Right();
    }
}
