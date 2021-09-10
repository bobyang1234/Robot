using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Robot_Challenge;
using System.Linq;

namespace RobotTests
{
    public class ReadFileTests
    {
        ReadFile file = new ReadFile();

        [Theory]
        [InlineData("D:\\test.txt", 19)]
        public void ReadTextFileShouldWork(string input, int expected_length)
        {
            List<string> test = file.ReadTextFile(input);
            Assert.Equal(expected_length, test.Count());
        }

        [Theory]
        [InlineData("dfasdfsa")]
        [InlineData("d432")]
        [InlineData("D:\\test.tx ")]
        [InlineData("D:\\test. txt  ")]
        public void ReadTextFileShouldGiveFileNotFoundException(string input)
        {
            Assert.Throws<System.IO.FileNotFoundException>(() => file.ReadTextFile(input));
        }

        [Theory]        
        [InlineData("D:\test.tx ")]
        [InlineData("D:\test. txt  ")]
        public void ReadTextFileShouldGiveArgumentException(string input)
        {
            Assert.Throws<System.ArgumentException>(() => file.ReadTextFile(input));
        }
    }
}
