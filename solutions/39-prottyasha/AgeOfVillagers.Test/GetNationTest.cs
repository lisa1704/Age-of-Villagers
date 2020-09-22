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
        public void BdCheck()
        {
            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Bangladeshi Farmers");
            AbstractNation expected = new Bangladesh();

            actual.Equals(expected);
        }

        [Fact]
        public void EgyptCheck()
        {
            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Egyptian Kings");
            AbstractNation expected = new Egypt();

            actual.Equals(expected);
        }

        [Fact]
        public void InuitCheck()
        {
            NationFactory nf = new NationFactory();
            AbstractNation actual = nf.getNation("Inuit Hunters");
            AbstractNation expected = new Inuit();

            actual.Equals(expected);
        }
        
    }
}
