using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void main_prints_Hello_World()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello World!", output);
        }
    }
}
