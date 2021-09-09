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
    }
}
