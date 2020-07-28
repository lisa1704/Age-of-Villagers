using System;
using Xunit;

namespace XUnitTestAgeOFVillagers
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int num = 76;
            Assert.Equal(76, num);
        }
    }
}
