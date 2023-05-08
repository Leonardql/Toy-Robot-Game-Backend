using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game
{
    public class Robot
    {
        private int col;
        private string facing;
        private int row;
        private bool placed;

        public Robot()
        {
            Placed = false;
        }

        public int Col { get => col; set => col = value; }
        public int Row { get => row; set => row = value; }
        public string Facing { get => facing; set => facing = value; }
        public bool Placed { get => placed; set => placed = value; }

        public bool FacingIsValid(string nfacing)
        {
            if (nfacing == "NORTH" || nfacing == "SOUTH" || nfacing == "WEST" || nfacing == "EAST")
            {
                return true;
            }
            return false;
        }


    }
}
