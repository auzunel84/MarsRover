<b>MARS ROVER</b>

A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is
curiously rectangular, must be navigated by the rovers so that their on board cameras can get a
complete view of the surrounding terrain to send back to Earth.
A rover's position and location is represented by a combination of x and y co-ordinates and a letter
representing one of the four cardinal compass points. The plateau is divided up into a grid to
simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom
left corner and facing North.
In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and
'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its
current spot. 'M' means move forward one grid point, and maintain the same heading.

Input:
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are
assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover
has two lines of input. The first line gives the rover's position, and the second line is a series of
instructions telling the rover how to explore the plateau.
The position is made up of two integers and a letter separated by spaces, corresponding to the x
and y co-ordinates and the rover's orientation.
Each rover will be finished sequentially, which means that the second rover won't start to move
until the first one has finished moving.

an example input: 

5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM


Output:
Each rover's final co-ordinates and heading.

sample output based on the input above;

1 3 N
5 1 E

<b>REQUIREMENTS FOR  RUNNING THE PROJECT</b>

You need to have Visual studio code/Visual Studio 2019/2022 and .Net Core 5 installed. 

<b>BUILDING AND RUNNING THE PROJECT</b>

On VS Code;

Open a terminal and then type;
<b>dotnet build</b>

and then;

<b>dotnet run --project MarsRover.App</b>

On Visual Studio;

Right click on the solution build and then run.

<b>RUNNING THE TESTS</b>

VS Code; on the terminal type '<b>dotnet test</b>'.

Visual Studio; use the test explorer.
