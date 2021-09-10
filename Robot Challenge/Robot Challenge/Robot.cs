using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Robot_Challenge
{
    public class Robot
    {
        public int current_x_position { get; set; }
        public int current_y_position { get; set; }
        public string current_orientation { get; set; }

        //This method takes in a string and determines if it contains a valid input
        //Valid inputs include move, report, left, right place [0-5],[0-5],[north,south,east,west]
        //Valid inputs are not case sensitive, as long as they are spelt correctly
        //Valid inputs cannot have blank characters in front of or after them
        //Valid inputs will return true, else returns false
        public bool CheckValidInput(string input)
        {
            Regex rgx = new Regex("^((MOVE)|(REPORT)|(LEFT)|(RIGHT)|(PLACE [0-9]+,[0-9]+,(north|south|east|west)))$", RegexOptions.IgnoreCase);
            if (rgx.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method takes in a string input containing the left command and changes the robot's orientation, it returns a string
        public string Left(string input)
        {
            switch (input)
            {
                case "NORTH":
                    input = "WEST";
                    break;
                case "WEST":
                    input = "SOUTH";
                    break;
                case "SOUTH":
                    input = "EAST";
                    break;
                case "EAST":
                    input = "NORTH";
                    break;
                default:
                    return input;

            }
            return input;
        }

        //This method takes in a string input containing the place command and changes the robot's x y coordinates and orientation
        //It will return back a Robot object
        public Robot Place(Robot robot, string input)
        {            
            string[] input_array = input.Remove(0, 6).Split(',');
            if (int.Parse(input_array[0]) > 5 || int.Parse(input_array[1]) > 5)
            {
                return robot;
            }
            else
            {
                robot.current_x_position = int.Parse(input_array[0]);
                robot.current_y_position = int.Parse(input_array[1]);
                robot.current_orientation = input_array[2].ToUpper();
                return robot;
            }
        }

        //This method takes in a string input containing the right command and changes the robot's orientation, it returns a string
        public string Right(string input)
        {
            switch (input)
            {
                case "NORTH":
                    input = "EAST";
                    break;
                case "EAST":
                    input = "SOUTH";
                    break;
                case "SOUTH":
                    input = "WEST";
                    break;
                case "WEST":
                    input = "NORTH";
                    break;
                default:
                    return input;

            }
            return input;
        }

        //This method takes in a string input containing the move command and changes the robot's x y coordinate accordingly
        //It returns back a Robot object
        public Robot Move(Robot robot)
        {
            switch (robot.current_orientation)
            {
                case "NORTH":
                    if (robot.current_y_position == 5)
                    {
                        return robot;
                    }
                    else
                    {
                        robot.current_y_position += 1;
                    }
                    break;
                case "EAST":
                    if (robot.current_x_position == 5)
                    {
                        return robot;
                    }
                    else
                    {
                        robot.current_x_position += 1;
                    }
                    break;
                case "SOUTH":
                    if (robot.current_y_position == 0)
                    {
                        return robot;
                    }
                    else
                    {
                        robot.current_y_position -= 1;
                    }
                    break;
                case "WEST":
                    if (robot.current_x_position == 0)
                    {
                        return robot;
                    }
                    else
                    {
                        robot.current_x_position -= 1;
                    }
                    break;
                default:
                    return robot;
            }
            return robot;
        }
    }
}
