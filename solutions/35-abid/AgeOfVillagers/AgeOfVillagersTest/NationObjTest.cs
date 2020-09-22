using System;
using AgeOfVillagers;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace AgeOfVillagersTest
{
    [TestClass]
    public class NationObjTest
    {

        [TestMethod]
        public void TestBangladeshiNationObj()
        {
            NationFactory BDobj = new NationFactory(new Panel());
            INation nation1 = BDobj.nationUpdate(0);
            INation nation2 = new BangladeshiFarmers(new Panel());
            nation1.Equals(nation2);
    
        }

        [TestMethod]
        public void TestArabianNationObj()
        {
            NationFactory Arabobj = new NationFactory(new Panel());
            INation nation1 = Arabobj.nationUpdate(1);
            INation nation2 = new ArabBedouins(new Panel());
            nation1.Equals(nation2);

        }

        [TestMethod]
        public void TestEgyptianNationObj()
        {
            NationFactory Egyobj = new NationFactory(new Panel());
            INation nation1 = Egyobj.nationUpdate(2);
            INation nation2 = new EgyptianKings(new Panel());
            nation1.Equals(nation2);

        }

        [TestMethod]
        public void TestInuitNationObj()
        {
            NationFactory Inuitobj = new NationFactory(new Panel());
            INation nation1 = Inuitobj.nationUpdate(3);
            INation nation2 = new InuitHunters(new Panel());
            nation1.Equals(nation2);

        }
    }
}
