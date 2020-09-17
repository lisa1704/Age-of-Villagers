using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public EgyptianKings()
        {
            color = Color.Yellow;
            nation_name = "Egyptian Kings";
        }

        public object getHouse(Point point)
        {
            return new EgyptianKingsHouse(point);
        }

        public string getNationName()
        {
            return nation_name;
        }

        public Color getTerrainColor()
        {
            return color;
        }

        public object getTree(Point point)
        {
            return new EgyptianKingsTree(point);
        }

        public object getWaterResource(Point point)
        {
            return new EgyptianKings_WaterResource(point);
        }
    }
}
