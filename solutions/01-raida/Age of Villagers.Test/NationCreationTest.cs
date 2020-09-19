using NUnit.Framework;
using Age_of_Villagers;
using System.Collections.Generic;

namespace Age_of_Villagers.Test
{
    public class NationCreationTest
    {
        INation nation;
        INationFactory factory;

        List<string> nationList = new List<string>() { "Bangladeshi Farmers", "Arab Bedouin", "Egyptian Kings", "Inuit Hunters" };
        [SetUp]
        public void Setup()
        {
            factory = new Nationfactory();
        }

        [Test]

        public void TestBDcreate()
        {
            INation nation=factory.GetNation(nationList[0]);
            new Bangladesh().Equals(nation);
        }
        [Test]
        public void TestARABcreate()
        {
            string selected = nationList[1];
            nation = factory.GetNation(selected);
            new Arab().Equals(nation);
        }
        [Test]
        public void TestEGYPTcreate()
        {
            string selected = nationList[2];
            nation = factory.GetNation(selected);
            new Egypt().Equals(nation);
        }
        [Test]
        public void TestINUITcreate()
        {
            string selected = nationList[3];
            nation = factory.GetNation(selected);
            new Inuit().Equals(nation);
        }
    }
}