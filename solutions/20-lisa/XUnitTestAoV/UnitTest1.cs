using System;
using Xunit;

namespace XUnitTestAoV
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);
        }
        [Fact]
        public void IsOK()
        {
            Assert.True(4 > 1);
        }
    }
}
