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
            if (board.IsValidLocation(row, col) && robot.IsFacingValid(facing))
            {
                if (robot.Placed)
                {
                    //remove old position
                    board.PlaceOnBoard(row, col, 0);
                    robot.Placed = false;

                    PlaceRobot(row, col, facing);
                }
                else
                {
                    robot.Row = row;
                    robot.Col = col;
                    robot.Facing = facing;

                    board.PlaceOnBoard(robot.Row,robot.Col, 1);

                    robot.Placed = true;
                }
            }
        }

        public void PlaceWall(int row, int col)
        {
            if(board.IsValidLocation(row,col) && board.IsEmptySquare(row,col))
            {
                board.PlaceOnBoard(row, col, 2);
            }
        }

        public void Report()
        {
            if (robot.Placed)
            {
                Console.WriteLine(robot.Row + "," + robot.Col + "," + robot.Facing);
            }
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
