using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace AgeOfVillagers.Test
{
    public class VillageStateTest
    {
        string villagename = "my village";
        public List<Point> points;

        [Fact]
        public void VillageNameTest()
        {
            Villagestate state = new Villagestate(villagename, null, null, null);

            Assert.Equal(villagename, state.villagename);
            Assert.Equal(villagename, state.GetVillageName());
        }

        [Fact]
        public void StateHouseTest()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 10));
            points.Add(new Point(10, 0));
            points.Add(new Point(10, 10));
            points.Add(new Point(110, 50));

            Villagestate state = new Villagestate(villagename, null, points, null);

            Assert.Equal(points, state.houses);
        }

        [Fact]
        public void StateTreeTest()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 10));
            points.Add(new Point(10, 0));
            points.Add(new Point(10, 10));
            points.Add(new Point(110, 50));

            Villagestate state = new Villagestate(villagename, points, null, null);

            Assert.Equal(points, state.trees);
        }

        [Fact]
        public void StateWaterSourceTest()
        {
            points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(0, 10));
            points.Add(new Point(10, 0));
            points.Add(new Point(10, 10));
            points.Add(new Point(110, 50));

            Villagestate state = new Villagestate(villagename, null, null, points);

            Assert.Equal(points, state.watersources);
        }
    }
}
