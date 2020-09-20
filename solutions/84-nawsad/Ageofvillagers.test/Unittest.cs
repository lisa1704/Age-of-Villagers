using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Ageofvillagers
{
    public class Unittest
    {   
        [Fact]
        void unittest1()
        {
            int output = 5 * 1;
            int expected = 5;
            Assert.Equal(expected, output);
        }

    }
}
