using NUnit.Framework;
using Age_of_Villagers;
namespace Age_of_Villagers.Test
{
    public class Tests
    {
        INation nation;
        INationFactory factory;
        [SetUp]
        public void Setup()
        {
            factory = new Nationfactory();
        }

        [Test]
        public void Test1()
        {
            
            string selected ="Bangladeshi Farmers";
            nation=factory.GetNation(selected);
            Assert.AreEqual(nation,new Bangladesh());
        }
    }
}