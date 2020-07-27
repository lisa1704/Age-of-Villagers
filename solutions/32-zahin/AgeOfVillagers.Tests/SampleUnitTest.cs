using System;
using Xunit;

namespace AgeOfVillagers.Tests
{
    public class SampleUnitTest
    {
        [Fact]
        public void SampleTest()
        {
            int actual = 2;
            var expected = 2;
            Assert.Equal(expected, actual);
        }
    }
}
