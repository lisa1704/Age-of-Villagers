using NUnit.Framework;
using System;
using Xunit;


namespace LabAssignment
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            int var = 2;
            var expectedValue = 2;
            Assert.Equals(expectedValue, var);
        }
    }
}
