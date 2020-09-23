using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Age_of_villagers.Test
{
    public class NationNametest
    {
        ArabBedouin arabNation = new ArabBedouin();
        string NationName = "Arab Bedouin";
        

        [Fact]

        public void ArabNameTest()
        {
            Nation nation = new Nation();
            INations actual = nation.CheckVillage(NationName);
            Assert.Equal(arabNation.GetType(),actual.GetType());
        }



        BangladeshiFarmers banglaNation = new BangladeshiFarmers();
        string NationName2 = "Bangladeshi Farmers";

        [Fact]

        public void BanglaNameTest()
        {
            Nation nation = new Nation();
            INations actual1 = nation.CheckVillage(NationName2);
            Assert.Equal(banglaNation.GetType(), actual1.GetType());
        }



        EgyptianKings EgyptNation = new EgyptianKings();
        string NationName3 = "Egyptian Kings";

        [Fact]

        public void EgyptNameTest()
        {
            Nation nation = new Nation();
            INations actual1 = nation.CheckVillage(NationName3);
            Assert.Equal(EgyptNation.GetType(), actual1.GetType());
        }



        
















    }
}

