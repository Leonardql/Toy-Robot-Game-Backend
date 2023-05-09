using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game
{
    public class Game : ICommand
    {
        readonly Board board;
        readonly Robot robot;

        public Game(Board board, Robot robot)
        {
            this.board = board;
            this.robot = robot;
        }

        public void PlaceRobot(int row, int col, string facing)
        {
            if (board.IsValidLocation(row, col) && Robot.IsFacingValid(facing))
            {
                if (robot.Placed)
                {
                    //remove old position
                    board.PlaceOnBoard(robot.Row,robot.Col, 0);
                    robot.Placed = false;

                    PlaceRobot(row, col, facing);
                }
                else
                {
                    robot.Row = row;
                    robot.Col = col;
                    robot.Facing = facing;

                    board.PlaceOnBoard(robot.Row,robot.Col, 1);
                    Console.WriteLine("This places a robot at row " + robot.Row + ", column "+ robot.Col + ", facing "+  robot.Facing  +".");
                    robot.Placed = true;
                }
            }
        }

        public void PlaceWall(int row, int col)
        {
            if(board.IsValidLocation(row,col) && board.IsEmptySquare(row,col))
            {
                board.PlaceOnBoard(row, col, 2);
                Console.WriteLine("This places a wall at row "+ row + ", column "+ col +".");
            }
        }

        public void Report()
        {
            if (robot.Placed)
            {
                Console.WriteLine(robot.Row + "," + robot.Col + "," + robot.Facing);
            }
            else
            {
                Console.WriteLine("no robot on the board, place a robot using the command PLACE_ROBOT ROW,COL,FACING");
            }
        }


        public void Move()
        {
            if (robot.Placed)
            {
                switch (robot.Facing)
                {
                    case "NORTH":

                        if (board.IsEmptySquare(robot.Row, (robot.Col == board.Cols) ? 1 : robot.Col + 1))
                        {

                            PlaceRobot(robot.Row, (robot.Col == board.Cols) ? 1 : robot.Col + 1, robot.Facing);
                        }
                        break;
                    case "SOUTH":
                        if (board.IsEmptySquare(robot.Row, (robot.Col == 1) ? board.Cols : robot.Col - 1))
                        {

                            PlaceRobot(robot.Row, (robot.Col == 1) ? board.Cols : robot.Col - 1, robot.Facing);
                        }
                        break;
                    case "EAST":
                        if (board.IsEmptySquare((robot.Row == board.Rows) ? 1 : robot.Row + 1, robot.Col))
                        {

                            PlaceRobot((robot.Row == board.Rows) ? 1 : robot.Row + 1, robot.Col, robot.Facing);
                        }
                        break;
                    case "WEST":
                        if (board.IsEmptySquare((robot.Row == 1) ? board.Rows : robot.Row - 1, robot.Col))
                        {

                            PlaceRobot((robot.Row == 1) ? board.Rows : robot.Row - 1, robot.Col, robot.Facing);
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("no robot on the board, place a robot using the command PLACE_ROBOT ROW,COL,FACING");
            }
            
        }


        public void Left()
        {
            if (robot.Placed)
            {
                switch (robot.Facing)
                {
                    case "NORTH":
                        robot.Facing = "WEST";
                        break;

                    case "SOUTH":
                        robot.Facing = "EAST";
                        break;

                    case "WEST":
                        robot.Facing = "SOUTH";
                        break;

                    case "EAST":
                        robot.Facing = "NORTH";
                        break;
                }
            }
        }

        public void Right()
        {
            if (robot.Placed)
            {
                switch (robot.Facing)
                {
                    case "NORTH":
                        robot.Facing = "EAST";
                        break;

                    case "SOUTH":
                        robot.Facing = "WEST";
                        break;

                    case "WEST":
                        robot.Facing = "NORTH";
                        break;

                    case "EAST":
                        robot.Facing = "SOUTH";
                        break;
                }
            }
        }


    }
}
