using System;
using System.IO;
using Xunit;

namespace LeapYear.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void isLeapYear_agrees_year_4()
        {
            Program program = new Program();

            bool output = program.isLeapYear(4);

            Assert.Equal(true, output);
        }

        [Fact]
        public void isLeapYear_disagrees_year_5()
        {
            Program program = new Program();

            bool output = program.isLeapYear(5);

            Assert.Equal(false, output);
        }

        [Fact]
        public void isLeapYear_disagrees_year_200()
        {
            Program program = new Program();

            bool output = program.isLeapYear(200);

            Assert.Equal(false, output);
        }

        [Fact]
        public void isLeapYear_agrees_year_400()
        {
            Program program = new Program();

            bool output = program.isLeapYear(400);

            Assert.Equal(true, output);
        }

        [Fact]
        public void isLeapYear_agrees_year_0()
        {
            Program program = new Program();

            bool output = program.isLeapYear(0);

            Assert.Equal(true, output);
        }

        [Fact]
        public void main_agrees_year_4()
        {
            var reader = new StringReader("1704");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[] { });
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay", output);
        }

        [Fact]
        public void main_disagrees_year_5()
        {
        
            var reader = new StringReader("1705");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[] { });
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("nay", output);
        }

        [Fact]
        public void main_disallows_year_4()
        {
        
            var reader = new StringReader("4");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[] { });
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Contains("ERROR", output);
        }

        [Fact]
        public void main_disallows_letters()
        {
        
            var reader = new StringReader("abcdefg");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[] { });
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Contains("ERROR", output);
        }

        [Fact]
        public void main_disallows_special_characters()
        {
        
            var reader = new StringReader("!?#¤");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[] { });
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Contains("ERROR", output);
        }

        [Fact]
        public void main_disallows_float_numbers()
        {
        
            var reader = new StringReader("1893.573");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[] { });
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Contains("ERROR", output);
        }
    }
}
