using MarsRover.Business;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class MRoverTests
    {
        [Theory]
        [InlineData("N", 5, 5, 1, 2, "LMLMLMLMM", "1 3 N")]
        [InlineData("E", 5, 5, 3, 3, "MMRMMRMRRM", "5 1 E")]
        [InlineData("E", 5, 5, 3, 3, "", "3 3 E")] //Do not move if not proper instruction is given
        [InlineData("E", 5, 5, 3, 3, "ABC", "3 3 E")] //Do not move if not proper instruction is given
        public void MRover_Can_Follow_Instructions_Properly(string direction,
            int plateauTopX,
            int plateauTopY,
            int x,
            int y,
            string instructions,
            string expectedResult)
        {
            var rover = new MRover(direction,
                plateauTopX,
                plateauTopY,
                x,
                y);

            rover.FollowInstructions(instructions);

            Assert.Equal(expectedResult, rover.GetPosition());

        }

        [Theory]
        [InlineData("A", 5, 5, 1, 2, "LMLMLMLMM", "1 3 N")]
        public void MRover_Fail_On_Improper_Direction(string direction,
            int plateauTopX,
            int plateauTopY,
            int x,
            int y,
            string instructions,
            string expectedResult)
        {
            Action act = () => new MRover(direction,
                plateauTopX,
                plateauTopY,
                x,
                y);

            var exception = Assert.Throws<Exception>(act);

            Assert.Equal("You need to specify a proper direction(N, W, E ,S).", exception.Message);

        }
    }
}
