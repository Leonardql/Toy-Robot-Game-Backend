# Toy-Robot-Game-Backend

This application simulates a toy robot moving game on a 5x5 square board. The robot can move freely, but cannot move onto squares that have been placed as walls by the user. If the robot reaches the edge of the table, the robot will be placed on the opposite side off the board. 

The bottom left of the board is (1, 1) (row 1, column 1), and the top right corner of the board is (5, 5)

## Commands in the following format
```
PLACE_ROBOT ROW,COL,FACING
PLACE_WALL ROW,COL
REPORT
MOVE
LEFT
RIGHT
```
```PLACE_ROBOT``` 
This command places a robot at a given coordinate with an initial Facing direction

* If there are no robots on the board, the PLACE_ROBOT places one at the coordinate specified.
* If there is already a robot, a new PLACE_ROBOT command moves the existing robot to the new location.
* If the coordinate or facing value is invalid, then the game ignores it and does nothing.

```PLACE_WALL``` This command places a wall at the given coordinate.
* If the target location is empty, then it adds a wall to it.
* The user can add as many walls as they like until the board is filled.
* If the target location is occupied (by the robot, or another wall), then this command is ignored.
* Invalid coordinates are ignored.

```REPORT``` The game prints out the current location and facing direction of the robot.
* If there are no robots on the board, this command is ignored.

```MOVE``` moves the robot 1 space forward in the direction it is currently facing.
* If there are no robots on the board, this command is ignored.
* If there is a wall in front of the robot, this command is ignored.
* If the robot has already reached the edge of the board, the robot gets moved to the opposite side of the board.

```LEFT / RIGHT```
The turn commands LEFT and RIGHT, turns the robot 90 degrees to its current left or right.
* If there are no robots on the board, this command is ignored.


## Example Input and Output:
**Example a:**
```
PLACE_ROBOT 3,3,NORTH
PLACE_WALL 3,5
MOVE
MOVE
RIGHT
MOVE
MOVE
MOVE
REPORT
```

Expected output: 

 ``` 1,4,EAST```

**Example b:**
```
PLACE_ROBOT 2,2,WEST
PLACE_WALL 1,1
PLACE_WALL 2,2
PLACE_WALL 1,3
LEFT
LEFT
MOVE
REPORT
```
Expected output: 

 ``` 3,2,EAST```

 ## Instructions

The application is written in dotnet 7. To run the project, you will need to install the dotnet 7 runtime and sdk. The solution can be found in the root folder, and the tests can be found in Toy-Robot-GameTests folder. 

after installation you can build the solution and run the console application. Commands will not be executed automatically.

To run the tests, load up the project in your preferred IDE and execute the tests from the Game_Tests file using a test runner that runs mstestv2 test. The testing was done using the mstestv2 framework.

I recommend using Visual Studio 2022

## Future ideas for similar projects
In this project, I decided not to implement the command pattern because I believe it is better suited for situations where commands can be unexecuted and a command history is important.

When a variable can only have a specific set of values, I prefer to use an enum rather than checking the value using a method. An example of this would be the names of the months, which never change and there are many of them, imo it is appropriate to use an enum when there are seven or more options.

Last thing, provide clear feedback to the user, such as error messages or prompts, to indicate when they have entered invalid inputs or encountered errors