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

        //This method takes a string which represents the path of the file you are accessing and returns a list of string        
        public List<string> ReadTextFile(string path)
        {            
            var lines = File.ReadAllLines(@path);
            List<string> output = new List<string>(lines);                 
            return output;
        }

    }
}
