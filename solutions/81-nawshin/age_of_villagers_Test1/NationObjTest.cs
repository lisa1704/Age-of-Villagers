using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using age_of_villagers;

namespace age_of_villagers_Test1
{
    [TestClass()]
    public class NationObjTest
    {

        [TestMethod()]
        public void Test_Bangladesh()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Bangladesh");
            INation expected = new Bangladeshi_Farmers();
            type.Equals(expected);
        }

        [TestMethod()]
        public void Test_Arab()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Arab");
            INation expected = new Arab_Bedouin();
            type.Equals(expected);
        }

        [TestMethod()]
        public void Test_Egypt()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Egypt");
            INation expected = new Egyptian_Kings();
            type.Equals(expected);
        }

        [TestMethod()]
        public void Test_Inuit()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("Inuit");
            INation expected = new Inuit_Hunters();
            type.Equals(expected);
        }

        [TestMethod()]
        public void Test_NoNation()
        {
            NationFactory nation = new NationFactory();
            INation type = nation.CreateNation("NoNation");
            INation expected = new NoNation();
            type.Equals(expected);
        }
    }
}
