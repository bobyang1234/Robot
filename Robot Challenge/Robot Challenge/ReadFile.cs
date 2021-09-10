using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Challenge
{
    public class ReadFile
    {
        Robot robot = new Robot();

        //This method takes a string which represents the path of the file you are accessing
        //and returns a list of string containing valid commands 
        public List<string> ReadTextFile(string path)
        {
            List<string> output = new List<string>();
            var lines = File.ReadAllLines(@path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (robot.CheckValidInput(lines[i]))
                {
                    output.Add(lines[i]);
                }
            }            
            return output;
        }

    }
}
