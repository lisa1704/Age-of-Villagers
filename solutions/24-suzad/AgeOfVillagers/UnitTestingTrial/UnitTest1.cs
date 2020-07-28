using System;
using Xunit;

namespace UnitTestingTrial
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int actual = 2;
            int expected = 2;
            Assert.Equal(expected, actual);
        }
    }
}
