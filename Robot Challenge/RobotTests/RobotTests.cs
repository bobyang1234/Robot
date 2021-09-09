using Robot_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RobotTests
{
    public class RobotTests
    {
        Robot robot = new Robot();

        [Theory]
        [InlineData("PLACE 0,0,NORTH")]
        [InlineData("place 0,0,NORTH")]
        [InlineData("PLACE 0,0,north")]
        [InlineData("PLACE 0,0,EAST")]
        [InlineData("PLACE 0,0,east")]
        [InlineData("PLACE 0,0,WEST")]
        [InlineData("PLACE 0,0,west")]
        [InlineData("PLACE 0,0,SOUTH")]
        [InlineData("PLACE 0,0,south")]
        [InlineData("PLacE 0,0,noRTh")]
        [InlineData("PLacE 23420,53252360,noRTh")]
        [InlineData("PLacE 4,4,noRTh")]
        [InlineData("Left")]
        [InlineData("Right")]
        [InlineData("MoVe")]
        [InlineData("REpORt")]
        public void CheckValidInputShouldBeTrue(string input)
        {
            Assert.True(robot.CheckValidInput(input));
        }

        [Theory]
        [InlineData("PLACE  0,0,NORTH")]
        [InlineData(" PLACE 0,0,NORTH")]
        [InlineData("PLACE  0,0,NORTH ")]
        [InlineData("PLACE -10,20,NORTH")]
        [InlineData("PLACE 10,-2,NORTH")]
        [InlineData("PLACE 1.23,2,NORTH")]
        [InlineData("PLACE 1,2.345,NORTH")]
        [InlineData("leeft")]
        [InlineData(" left ")]
        [InlineData(" right ")]
        [InlineData(" move ")]
        [InlineData(" report ")]
        public void CheckValidInputShouldBeFalse(string input)
        {
            Assert.False(robot.CheckValidInput(input));
        }

        [Theory]
        [InlineData("NORTH", "WEST")]
        [InlineData("WEST", "SOUTH")]
        [InlineData("SOUTH", "EAST")]
        [InlineData("EAST", "NORTH")]
        public void LeftShouldWork(string input, string expected)
        {
            Assert.Equal(expected, robot.Left(input));
        }

        [Theory]
        [InlineData("DSADF", "DSADF")]
        [InlineData("DS2345ADsdfF", "DS2345ADsdfF")]
        [InlineData("32345dsafd25", "32345dsafd25")]
        public void LeftShouldFail(string input, string expected)
        {
            Assert.Equal(expected, robot.Left(input));
        }
    }
}
