using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public BangladeshiFarmers()
        {
            color = Color.GreenYellow;
            nation_name = "Bangladeshi Farmers";
        }

        public object getHouse(Point point)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public object getWaterResource(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
