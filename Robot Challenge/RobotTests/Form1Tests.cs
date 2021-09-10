using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Robot_Challenge;

namespace RobotTests
{
    public class Form1Tests
    {
        Form1 form = new Form1();

        public static IEnumerable<object[]> TestReportWorking =>
       new List<object[]>
       {
            new object[] { new Robot { current_x_position = 0, current_y_position = 5, current_orientation = "NORTH" }, "0,5,NORTH"},
            new object[] { new Robot { current_x_position = 0, current_y_position = 0, current_orientation = "WEST" }, "0,0,WEST"},
            new object[] { new Robot { current_x_position = 5, current_y_position = 0, current_orientation = "EAST" }, "5,0,EAST"},
            new object[] { new Robot { current_x_position = 0, current_y_position = 0, current_orientation = "SOUTH" }, "0,0,SOUTH"},
            new object[] { new Robot { current_x_position = 1, current_y_position = 5, current_orientation = "NORTH" }, "1,5,NORTH"},
            new object[] { new Robot { current_x_position = 2, current_y_position = 5, current_orientation = "NORTH" }, "2,5,NORTH"},
            new object[] { new Robot { current_x_position = 3, current_y_position = 5, current_orientation = "NORTH" }, "3,5,NORTH"},
            new object[] { new Robot { current_x_position = 4, current_y_position = 5, current_orientation = "NORTH" }, "4,5,NORTH"},
            new object[] { new Robot { current_x_position = 5, current_y_position = 5, current_orientation = "NORTH" }, "5,5,NORTH"},
       };

        [Theory]
        [MemberData(nameof(TestReportWorking))]
        public void ReportShouldWork(Robot robot, string expected)
        {
            Assert.Equal(expected, form.Report(robot));
        }


    }
}
