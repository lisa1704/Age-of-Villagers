using System;
using Xunit;

namespace Age_Of_Villegers_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int output = 4, expected = 4;
            Assert.Equal(expected, output);
        }
    }
}
