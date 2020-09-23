using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Age_of_Villagers_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BangladeshiNation()
        {
            var nationCreator = new NationCreator();
            INation nation = nationCreator.GetNation("Bangladeshi Farmers");
            var obj1Str = JsonConvert.SerializeObject(nation);
            var obj2Str = JsonConvert.SerializeObject(new Bangladeshi());
            Assert.Equals(obj1Str, obj2Str);
        }
    }

    [TestMethod]
    public void EgyptianNationn()
    {
        var nationCreator = new NationCreator();
        INation nation = nationCreator.GetNation("Egyptian Kings");
        var obj1Str = JsonConvert.SerializeObject(nation);
        var obj2Str = JsonConvert.SerializeObject(new Egyptian());
        Assert.Equals(obj1Str, obj2Str);
    }

    [TestMethod]
    public void InuitNation()
    {
        var nationCreator = new NationCreator();
        INation nation = nationCreator.GetNation("Inuit Hunters");
        var obj1Str = JsonConvert.SerializeObject(nation);
        var obj2Str = JsonConvert.SerializeObject(new Inuit());
        Assert.Equals(obj1Str, obj2Str);
    }

}