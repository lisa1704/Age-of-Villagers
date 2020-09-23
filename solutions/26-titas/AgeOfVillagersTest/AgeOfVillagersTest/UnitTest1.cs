using AgeOfVillagers;
using System;
using Xunit;

namespace AgeOfVillagersTest
{
    public class UnitTest1
    {
        Form1 form=new Form1();
        BdFarmers bdFarmers = new BdFarmers();
        EgyptianKings egyptianKings = new EgyptianKings();
        ArabBedouin arabBedouin = new ArabBedouin();
        


        [Fact]

        public void BdfarmersObjectTest()
        {
            NationNameFactory name = new NationNameFactory("Bangladeshi Farmers");
            INation nation = name.NationNameFactoryMethod();

            Assert.IsType<BdFarmers>(nation);

        }
    }
}
