using System;
using Xunit;
using AgeOfVillagers;

namespace AgeOfVillagers.Test
{
    public class GetVillageComponentTest
    {
        [Fact]
        public void ArabTreeCheck()
        {
            bool check = false;

            NationFactory nf = new NationFactory();
            AbstractNation nation = nf.getNation("Arab Bedouins");
            IComponent component = nation.getComponent("tree");

            Assert.NotNull(component);  //Checks for null

            if (component is ArabTree)
            {
                check = true;
            }
            Assert.True(check);
        }

        [Fact]
        public void ArabHouseCheck()
        {
            bool check = false;

            NationFactory nf = new NationFactory();
            AbstractNation nation = nf.getNation("Arab Bedouins");
            IComponent component = nation.getComponent("house");

            Assert.NotNull(component);  //Checks for null

            if (component is ArabHouse)
            {
                check = true;
            }
            Assert.True(check);
        }

        [Fact]
        public void ArabRiverCheck()
        {
            NationFactory nf = new NationFactory();
            AbstractNation nation = nf.getNation("Arab Bedouins");
            IComponent component = nation.getComponent("water_source");

            Assert.Null(component);  //Checks for null             
        }
    }
}
