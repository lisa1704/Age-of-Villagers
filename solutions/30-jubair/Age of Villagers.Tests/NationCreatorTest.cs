using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;
using Age_of_Villagers.Nation;
using Age_of_Villagers.NationFactory;

namespace Age_of_Villagers.Tests
{
   public class NationCreatorTest
   
    {

        BangladeshiNationCreator bdCreator = new BangladeshiNationCreator();

        [Fact]
        public void BangladeshiNationCreatorNameTest()
        {
            Assert.Equal("Bangladeshi Farmers", bdCreator.GetNationName);
        }


        [Fact]
        public void BangladeshiFactoryTest()
        {
            Assert.IsType<BangladeshiFarmer>(bdCreator.CreateNation());
        }
        


        ArabNationCreator arabCreator = new ArabNationCreator();

        [Fact]
        public void ArabNationCreatorNameTest()
        {
            Assert.Equal("Arab Bedouin", arabCreator.GetNationName);
        }


        [Fact]
        public void ArabFactoryTest()
        {
            Assert.IsType<ArabBedouin>(arabCreator.CreateNation());
        }




        EgyptianNationCreator egyptCreator = new EgyptianNationCreator();

        [Fact]
        public void EgyptNationCreatorNameTest()
        {
            Assert.Equal("Egyptian Kings", egyptCreator.GetNationName);
        }


        [Fact]
        public void EgyptFactoryTest()
        {
            Assert.IsType<EgyptianKings>(egyptCreator.CreateNation());
        }




        InuitNationCreator inuitCreator = new InuitNationCreator();

        [Fact]
        public void InuitNationCreatorNameTest()
        {
            Assert.Equal("Inuit Hunters", inuitCreator.GetNationName);
        }


        [Fact]
        public void InuitFactoryTest()
        {
            Assert.IsType<InuitHunter>(inuitCreator.CreateNation());
        }




    }
}
