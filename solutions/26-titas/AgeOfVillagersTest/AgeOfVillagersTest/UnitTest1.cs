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
        [Fact]
        public void ArabBedouinObjectTest()
        {
            NationNameFactory name = new NationNameFactory("Arab Bedouin");
            INation nation = name.NationNameFactoryMethod();

            Assert.IsType<ArabBedouin>(nation);
        }

        [Fact]
        public void EgyptianKingsObjectTest()
        {
            NationNameFactory name = new NationNameFactory("Egyptian Kings");
            INation nation = name.NationNameFactoryMethod();

            Assert.IsType<EgyptianKings>(nation);
        }

        [Fact]
        public void InuitHuntersObjectTest()
        {
            NationNameFactory name = new NationNameFactory("Inuit Hunters");
            INation nation = name.NationNameFactoryMethod();

            Assert.IsType<InuitHunters>(nation);
        }
    }
}
