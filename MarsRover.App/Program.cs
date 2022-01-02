using MarsRover.Business;
using MarsRover.Business.Helpers;
using System;
using System.Collections.Generic;

namespace MarsRover.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var lineCounter = 1;
                int[] plateauCoordinates = null;
                List<Tuple<int, int, string>> roversLocations = new List<Tuple<int, int, string>>();
                List<string> roversActions = new List<string>();

                var argLine = Console.ReadLine();

                //Listen for instructions until an empty row
                while (!string.IsNullOrEmpty(argLine))
                {
                    if (lineCounter == 1)
                        plateauCoordinates = CommandLineParser.ParsePlateauCoordinates(argLine.TrimEnd());
                    else if (lineCounter % 2 == 0)
                        roversLocations.Add(CommandLineParser.ParseRoverLocation(argLine.TrimEnd()));
                    else if (lineCounter % 2 != 0)
                        roversActions.Add(argLine.Trim());

                    lineCounter++;

                    argLine = Console.ReadLine();
                };

                //Iterate through rovers and apply their actions, then print their locations
                for (int i = 0; i < roversLocations.Count; i++)
                {
                    var roverLocation = roversLocations[i];

                    //Having DI for resolving Rovers on runtime would be the way to go for real world scenarios. Factory design pattern can be used for different set of Rovers.
                    var rover = new MRover(roverLocation.Item3, plateauCoordinates[0], plateauCoordinates[1], roverLocation.Item1, roverLocation.Item2);

                    rover.FollowInstructions(roversActions[i]);

                    Console.WriteLine(rover.GetPosition());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
