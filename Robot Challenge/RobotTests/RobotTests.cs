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
        [InlineData("PLACE 5,5,west")]
        [InlineData("PLACE 1,1,SOUTH")]
        [InlineData("PLACE 2,2,south")]
        [InlineData("PLacE 3,3,noRTh")]        
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
        [InlineData("PLACE 20,2,NORTH")]
        [InlineData("PLACE 3,32,NORTH")]
        [InlineData("PLACE 10,-2,NORTH")]
        [InlineData("PLACE 1.23,2,NORTH")]
        [InlineData("PLACE 1,2.345,NORTH")]
        [InlineData("PLacE 23420,53252360,noRTh")]
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

        [Theory]
        [InlineData("PLACE 0,0,NORTH", 0, 0, "NORTH")]
        [InlineData("place 0,0,NORTH", 0, 0, "NORTH")]
        [InlineData("PLACE 0,0,north", 0, 0, "NORTH")]
        [InlineData("PLACE 0,0,EAST", 0, 0, "EAST")]
        [InlineData("PLACE 0,0,east", 0, 0, "EAST")]
        [InlineData("PLACE 0,0,WEST", 0, 0, "WEST")]
        [InlineData("PLACE 0,0,west", 0, 0, "WEST")]
        [InlineData("PLACE 0,0,SOUTH", 0, 0, "SOUTH")]
        [InlineData("PLACE 0,0,south", 0, 0, "SOUTH")]
        [InlineData("PLacE 0,0,noRTh", 0, 0, "NORTH")]
        [InlineData("PLACE 1,1,NORTH", 1, 1, "NORTH")]
        [InlineData("PLACE 2,2,NORTH", 2, 2, "NORTH")]
        [InlineData("PLACE 3,3,NORTH", 3, 3, "NORTH")]
        [InlineData("PLACE 4,4,NORTH", 4, 4, "NORTH")]
        [InlineData("PLACE 5,5,NORTH", 5, 5, "NORTH")]
        public void PlaceShouldWork(string input, int expected_x, int expected_y, string expected_orientation)
        {
            Assert.Equal(expected_x, robot.Place(robot, input).current_x_position);
            Assert.Equal(expected_y, robot.Place(robot, input).current_y_position);
            Assert.Equal(expected_orientation, robot.Place(robot, input).current_orientation);
        }

        [Theory]
        [InlineData("PLACE 10,32,NORTH", 0, 0, null)]
        [InlineData("place 8,6,NORTH", 0, 0, null)]
        [InlineData("PLACE 4,6,north", 0, 0, null)]
        [InlineData("PLACE 2,7,EAST", 0, 0, null)]
        [InlineData("PLACE 8,1,east", 0, 0, null)]
        [InlineData("PLACE 6,0,WEST", 0, 0, null)]
        [InlineData("PLACE 054345,0234234,west", 0, 0, null)]
        [InlineData("PLACE 06,01,SOUTH", 0, 0, null)]
        [InlineData("PLACE 01,06,south", 0, 0, null)]
        [InlineData("PLacE 5436436,76456,noRTh", 0, 0, null)]
        [InlineData("PLACE 13,165,NORTH", 0, 0, null)]
        [InlineData("PLACE 212,232,NORTH", 0, 0, null)]
        [InlineData("PLACE 332,334,NORTH", 0, 0, null)]
        [InlineData("PLACE 4,44,NORTH", 0, 0, null)]
        [InlineData("PLACE 52,5,NORTH", 0, 0, null)]
        public void PlaceShouldFail(string input, int expected_x, int expected_y, string expected_orientation)
        {
            Assert.Equal(expected_x, robot.Place(robot, input).current_x_position);
            Assert.Equal(expected_y, robot.Place(robot, input).current_y_position);
            Assert.Equal(expected_orientation, robot.Place(robot, input).current_orientation);
        }

        [Theory]
        [InlineData("NORTH", "EAST")]
        [InlineData("EAST", "SOUTH")]
        [InlineData("SOUTH", "WEST")]
        [InlineData("WEST", "NORTH")]
        public void RightShouldWork(string input, string expected)
        {
            Assert.Equal(expected, robot.Right(input));
        }

        [Theory]
        [InlineData("DSADF", "DSADF")]
        [InlineData("DS2345ADsdfF", "DS2345ADsdfF")]
        [InlineData("32345dsafd25", "32345dsafd25")]
        public void RightShouldFail(string input, string expected)
        {
            Assert.Equal(expected, robot.Right(input));
        }

        public static IEnumerable<object[]> TestRobotDataWorking =>
        new List<object[]>
        {
            new object[] { new Robot { current_x_position = 0, current_y_position = 0, current_orientation = "NORTH" }, 1},
            new object[] { new Robot { current_x_position = 4, current_y_position = 0, current_orientation = "WEST" }, 3},
            new object[] { new Robot { current_x_position = 4, current_y_position = 0, current_orientation = "EAST" }, 5},
            new object[] { new Robot { current_x_position = 0, current_y_position = 3, current_orientation = "SOUTH" }, 2},
            new object[] { new Robot { current_x_position = 1, current_y_position = 1, current_orientation = "NORTH" }, 2},
            new object[] { new Robot { current_x_position = 2, current_y_position = 2, current_orientation = "NORTH" }, 3},
            new object[] { new Robot { current_x_position = 3, current_y_position = 3, current_orientation = "NORTH" }, 4},
            new object[] { new Robot { current_x_position = 4, current_y_position = 4, current_orientation = "NORTH" }, 5},
            new object[] { new Robot { current_x_position = 5, current_y_position = 4, current_orientation = "NORTH" }, 5},
        };

        [Theory]
        [MemberData(nameof(TestRobotDataWorking))]
        public void MoveShouldWork(Robot robot, int expected_value)
        {
            robot = robot.Move(robot);
            if (robot.current_orientation == "NORTH" || robot.current_orientation == "SOUTH")
            {
                Assert.Equal(expected_value, robot.current_y_position);
            }
            else
            {
                Assert.Equal(expected_value, robot.current_x_position);
            }
        }

        public static IEnumerable<object[]> TestRobotDataFailing =>
        new List<object[]>
        {
            new object[] { new Robot { current_x_position = 0, current_y_position = 5, current_orientation = "NORTH" }, 5},
            new object[] { new Robot { current_x_position = 0, current_y_position = 0, current_orientation = "WEST" }, 0},
            new object[] { new Robot { current_x_position = 5, current_y_position = 0, current_orientation = "EAST" }, 5},
            new object[] { new Robot { current_x_position = 0, current_y_position = 0, current_orientation = "SOUTH" }, 0},
            new object[] { new Robot { current_x_position = 1, current_y_position = 5, current_orientation = "NORTH" }, 5},
            new object[] { new Robot { current_x_position = 2, current_y_position = 5, current_orientation = "NORTH" }, 5},
            new object[] { new Robot { current_x_position = 3, current_y_position = 5, current_orientation = "NORTH" }, 5},
            new object[] { new Robot { current_x_position = 4, current_y_position = 5, current_orientation = "NORTH" }, 5},
            new object[] { new Robot { current_x_position = 5, current_y_position = 5, current_orientation = "NORTH" }, 5},
        };

        [Theory]
        [MemberData(nameof(TestRobotDataWorking))]
        public void MoveShouldFail(Robot robot, int expected_value)
        {
            robot = robot.Move(robot);
            if (robot.current_orientation == "NORTH" || robot.current_orientation == "SOUTH")
            {
                Assert.Equal(expected_value, robot.current_y_position);
            }
            else
            {
                Assert.Equal(expected_value, robot.current_x_position);
            }
        }
    }
}
