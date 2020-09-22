using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AgeOfVillagers;

namespace AgeOfVillagers.Test
{
    public class GetNationTest
    {
        [Fact]
        public void ArabCheck()
        {
            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Arab Bedouins");
            AbstractNation expected = new Arab();

            actual.Equals(expected);
        }

        

        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);
        }
    }
}
