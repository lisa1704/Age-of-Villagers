using Xunit;
using System.Drawing;
using Newtonsoft.Json;
using AgeOfVillagers.House;
using AgeOfVillagers.Components;
using System.Collections.Generic;

namespace AgeOfVillagersTest
{
    public class HouseTest
    {
        [Fact]
        public void BangladeshiHouseTest()
        {
            BangladeshiHouse bangladeshiHouse = new BangladeshiHouse(new Point(10, 10), new AgeOfVillagers.Data_Objects.ElementSize(16, 16));

            List<IComponent> components = new List<IComponent>();

            components.Add(new Triangle(new Point(18, 4), new Point(10, 10), new Point(26, 10)));
            components.Add(new AgeOfVillagers.Components.Rectangle(new Point(10, 10), new Point(26, 10), new Point(10, 20), new Point(26, 20)));

            var obj1Str = JsonConvert.SerializeObject(bangladeshiHouse.getComponents());
            var obj2Str = JsonConvert.SerializeObject(components);

            Xunit.Assert.Equal(obj1Str, obj2Str);
        }
    }
}
