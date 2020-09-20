using System;
using Xunit;
using AgeOfVillagersTest;
using AgeOfVillagers;
using Newtonsoft.Json;

namespace AgeOfVillagersTest
{
    public class NationTypeTest
    {
        [Fact]
        public void BangladeshiNation()
        {
            NationCreator nationCreator = new NationCreator();
            INation nation = nationCreator.GetNation("Bangladeshi Farmers");
            var obj1Str = JsonConvert.SerializeObject(nation);
            var obj2Str = JsonConvert.SerializeObject(new Bangladeshi());
            Xunit.Assert.Equal(obj1Str, obj2Str);
        }

        [Fact]
        public void EgyptianNation()
        {
            NationCreator nationCreator = new NationCreator();
            INation nation = nationCreator.GetNation("Egyptian Kings");
            var obj1Str = JsonConvert.SerializeObject(nation);
            var obj2Str = JsonConvert.SerializeObject(new Egyptian());
            Xunit.Assert.Equal(obj1Str, obj2Str);
        }

        [Fact]
        public void ArabianNation()
        {
            NationCreator nationCreator = new NationCreator();
            INation nation = nationCreator.GetNation("Arab Bedouin");
            var obj1Str = JsonConvert.SerializeObject(nation);
            var obj2Str = JsonConvert.SerializeObject(new Arab());
            Xunit.Assert.Equal(obj1Str, obj2Str);
        }

        [Fact]
        public void InuitNation()
        {
            NationCreator nationCreator = new NationCreator();
            INation nation = nationCreator.GetNation("Inuit Hunters");
            var obj1Str = JsonConvert.SerializeObject(nation);
            var obj2Str = JsonConvert.SerializeObject(new Inuit());
            Xunit.Assert.Equal(obj1Str, obj2Str);
        }
    }
}
