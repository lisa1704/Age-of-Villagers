using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Age_of_villagers
{
    public class UnitTest
    {

        public void Test()
        {
            int a = 10;
            int b = 20;
            var c = a + b;
          
            Assert.Equals(30, c);
        }

        public void EqualityTest()
        {
            int a = 2;
            int b = 2;
            Assert.Equals(a, b);
        }


    }
}
