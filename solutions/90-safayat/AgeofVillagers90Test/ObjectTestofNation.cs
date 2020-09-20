using System;
using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class ObjectTestofNation
    {
        [TestMethod]
        public void TestBangladeshiFarmersNationObject()
        {
            NationFactory BFobj = new NationFactory();
            INation nation = BFobj.GetNation("Bangladeshi Farmers");
            INation nation1 = new BangladeshiFarmers();
            nation.Equals(nation1);
        }

        [TestMethod]
        public void TestEgyptianKingNationObject()
        {
            NationFactory EKobj = new NationFactory();
            INation nation = EKobj.GetNation("Egytian Kings");
            INation nation1 = new EgyptianKings();
            nation.Equals(nation1);
        }

        [TestMethod]
        public void TestInuitHuntersNationObject()
        {
            NationFactory IHobj = new NationFactory();
            INation nation = IHobj.GetNation("Inuit HUnters");
            INation nation1 = new InuitHunters();
            nation.Equals(nation1);
        }

        [TestMethod]
        public void TestArabBedNationObject()
        {
            NationFactory ABobj = new NationFactory();
            INation nation = ABobj.GetNation("Arab Bedouin");
            INation nation1 = new ArabBedouin();
            nation.Equals(nation1);
        }

        [TestMethod]
        public void TestNullNationObject()
        {
            NationFactory NNobj = new NationFactory();
            INation nation = NNobj.GetNation("");
            INation nation1 = new NullNation();
            nation.Equals(nation1);
        }
    }
}
