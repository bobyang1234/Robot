﻿using System;
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

        public Robot Place(Robot robot, string input)
        {
            int i;
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
    }
}
