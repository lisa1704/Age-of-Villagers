using System;
using Xunit;

namespace Age_Of_Villagers_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int value1 = 2;
            int value2 = 2;

            var correct = value1 + value2;

            Assert.AreEqual(4, correct);
        }
    }
}
