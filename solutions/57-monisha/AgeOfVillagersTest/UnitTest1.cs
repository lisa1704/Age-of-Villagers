using System;
using Xunit;

namespace AgeOfVillagersTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 2 + 2;
        Assert.Equal(4, a);
            

        }
        [Fact]
        public void Test2()
        {
            string text = "Test Created";
            Assert.Equal("Test Created", text);


        }
    }
}
