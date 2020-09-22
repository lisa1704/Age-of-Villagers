using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AgeOfVillagers;
using System.Linq.Expressions;

namespace AgeOfVillagers.Test
{
    public class GetNationTest
    {
        [Fact]
        public void ArabCheck()
        {
            bool check = false;

            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Arab Bedouins");

            Assert.NotNull(actual);  //Checks for null

            if (actual is Arab)
            {
                check = true;
            }
            Assert.True(check);
        }

        [Fact]
        public void BdCheck()
        {
            bool check = false;

            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Bangladeshi Farmers");

            Assert.NotNull(actual);  //Checks for null

            if (actual is Bangladesh)
            {
                check = true;
            }
            Assert.True(check);
        }

        [Fact]
        public void EgyptCheck()
        {
            bool check = false;

            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Egyptian Kings");

            Assert.NotNull(actual);  //Checks for null

            if (actual is Egypt)
            {
                check = true;
            }
            Assert.True(check);
        }

        [Fact]
        public void InuitCheck()
        {
            bool check = false;

            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Inuit Hunters");
                        
            Assert.NotNull(actual);  //Checks for null
            
            if (actual is Inuit)
            {
                check = true;
            }
            Assert.True(check);
        }
        
    }
}
