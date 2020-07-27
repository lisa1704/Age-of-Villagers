using System;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int var = 2;
            var expectedValue = 2;
            Assert.Equal(expectedValue, var);
        }
    }
}
