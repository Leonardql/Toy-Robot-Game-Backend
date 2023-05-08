using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot_Game
{
    internal class Simulation
    {
        /*
         //Copy and paste these commands in the console if you want to test it.

        PLACE_ROBOT 3,3,NORTH
        PLACE_WALL 3,5
        MOVE
        MOVE
        RIGHT
        MOVE
        MOVE
        MOVE
        REPORT

        ==================

        PLACE_ROBOT 2,2,WEST
        PLACE_WALL 1,1
        PLACE_WALL 2,2
        PLACE_WALL 1,3
        LEFT
        LEFT
        MOVE
        REPORT

        */
        public static void Main(string[] args)
        {
            Board board = new Board(5, 5);
            Robot robot = new Robot();

            Game game = new Game(board, robot);


            string fullCommand;
           
            fullCommand = Console.ReadLine();

            while (fullCommand != "EXIT")
            {
                string[] command = fullCommand.Split(" ");
                
                switch (command[0])
                {
                    case "PLACE_ROBOT":
                        string[] placeRobotParameters = command[1].Split(",");
                        game.PlaceRobot(int.Parse(placeRobotParameters[0]), int.Parse(placeRobotParameters[1]), placeRobotParameters[2]);
                        break;

                    case "PLACE_WALL":
                        string[] placeWallParameters = command[1].Split(",");
                        game.PlaceWall(int.Parse(placeWallParameters[0]), int.Parse(placeWallParameters[1]));
                        break;

                    case "REPORT":
                        game.Report();
                        break;

                    case "MOVE":
                        game.Move();
                        break;

                    case "LEFT":
                        game.Left();
                        break;

                    case "RIGHT":
                        game.Right();
                        break;

                }



                fullCommand = Console.ReadLine();
            }
            
        }
    }
}
