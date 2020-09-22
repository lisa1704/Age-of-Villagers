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
        private Panel drawingPanel;

        [TestMethod]
        public void TestBangladeshiNationObj()
        {
            NationFactory BDobj = new NationFactory(drawingPanel);
            INation nation1 = BDobj.nationUpdate(0);
            INation nation2 = new BangladeshiFarmers(drawingPanel);
            nation1.Equals(nation2);
    
        }

        [TestMethod]
        public void TestArabianNationObj()
        {
            NationFactory Arabobj = new NationFactory(drawingPanel);
            INation nation1 = Arabobj.nationUpdate(1);
            INation nation2 = new ArabBedouins(drawingPanel);
            nation1.Equals(nation2);

        }

        [TestMethod]
        public void TestEgyptianNationObj()
        {
            NationFactory Egyobj = new NationFactory(drawingPanel);
            INation nation1 = Egyobj.nationUpdate(2);
            INation nation2 = new EgyptianKings(drawingPanel);
            nation1.Equals(nation2);

        }

        [TestMethod]
        public void TestInuitNationObj()
        {
            NationFactory Inuitobj = new NationFactory(drawingPanel);
            INation nation1 = Inuitobj.nationUpdate(3);
            INation nation2 = new InuitHunters(drawingPanel);
            nation1.Equals(nation2);

        }
    }
}
