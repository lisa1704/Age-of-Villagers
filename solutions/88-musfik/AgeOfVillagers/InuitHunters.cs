using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public InuitHunters()
        {
            color = Color.White;
            nation_name = "Inuit Hunters";
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
