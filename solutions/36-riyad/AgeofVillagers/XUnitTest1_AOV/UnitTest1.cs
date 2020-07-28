using System;
using Xunit;

namespace AgeOfVillagersTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int givenValue = 2;
            int expectedValue = 2;

            Assert.Equal(givenValue, expectedValue);

        }
    }
}
