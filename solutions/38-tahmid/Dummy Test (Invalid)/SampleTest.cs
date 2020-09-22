using System;
using Xunit;

namespace AgeOfVillagersTest
{
    public class SampleTest
    {
        [Fact]
        public void sampleTest1()
        {
            Assert.True(2 >1);
        }

        [Fact]
        public void sampleTest2()
        {
            int a = 2;
            Assert.Equal(a, 2);
        }
    }
}
