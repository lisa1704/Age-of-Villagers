using System;
using Xunit;

namespace age_of_villagers_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 2,b=2;
            Assert.Equal(4,a+b);
        }
    }
}
