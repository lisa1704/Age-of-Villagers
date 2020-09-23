using age_of_villagers.nation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace age_of_villagers.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(89, 89);
        }
        
    }

   [TestClass]
   public class UnitTestbackgroundcolor
    {
        [TestMethod]
        public void bdcolourtest()
        {
            Color s = Color.Green;
            bangladeshifarmers c = new bangladeshifarmers();
            Assert.AreEqual(s, c.getTerrainColor());
        }
    }
}
