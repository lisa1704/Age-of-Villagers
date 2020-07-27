using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DPLabAssignment
{
    public class Class1
    {
        [Fact]
        public void Test1()
        {
            int var = 2;
            int expected = 2;
            Assert.Equals(expected, var);
        }
    }
}
