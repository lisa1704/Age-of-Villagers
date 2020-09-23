using System;
using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2,2);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(16, new ArabHouse().getHeight());
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(24, new BangladeshiWaterResource().getHeight());
        }
    }
}
