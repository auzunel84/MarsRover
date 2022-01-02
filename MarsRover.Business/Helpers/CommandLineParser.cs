using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Business.Helpers
{
    public static class CommandLineParser
    {
        public static int[] ParsePlateauCoordinates(string input)
        {
            var splitted = input.Split(' ');
            if (splitted.Length < 2)
                return new int[0];

            return splitted.Select(s => Convert.ToInt32(s)).Take(2).ToArray();
        }

        public static Tuple<int, int, string> ParseRoverLocation(string input)
        {
            var splitted = input.Split(' ');
            if (splitted.Length < 3)
                return Tuple.Create(0, 0, string.Empty);

            return Tuple.Create(Convert.ToInt32(splitted[0]),
                Convert.ToInt32(splitted[1]),
                splitted[2].ToUpperInvariant());

        }
    }
}
