using System;
using Xunit;

namespace XUnitTestProject_AgeOfVilager
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int value1 = 2;
            int value2 = 2;

            var result = value1 + value2;

            Assert.Equal(4, result);

        }
    }
}
