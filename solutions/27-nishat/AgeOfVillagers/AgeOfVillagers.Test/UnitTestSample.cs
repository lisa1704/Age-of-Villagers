using System;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class UnitTestSample
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);

        }
    }

    public class NationFactoryTest
    {
        [Fact]
        public void BangladeshiNationFactoryTest()
        {
            Assert.Equal(2, 2);
        }
    }
}
