using System;
using Xunit;

namespace age_of_villagers_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int actual = 2;
            var expected = 2;
            Assert.Equal(expected, actual);
        }
    }
}
