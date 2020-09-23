using System;
using Xunit;
using AgeOfVillagers;
using System.Drawing;

namespace XUnitTestAoV
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 2, b = 2;
            Assert.Equal(4, a+b);
        }
        [Fact]
        public void IsOK()
        {
            Assert.True(4 > 1);
        }
    }
}
