using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        private readonly Color color = Color.Green;
        private String nation_name = "Bangladeshi Farmers";

        public BangladeshiFarmers()
        {
            
        }

        public string nationName { get => nation_name; set => nation_name = value; }

        public House getHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }

        
        public string getNationName()
        {
            return nation_name;
        }
        

        public Color getTerrainColor()
        {
            return color;
        }

        public Tree getTree(Point point)
        {
            return new BangladeshiTree(point);
        }

        public WaterResource getWaterResource(Point point)
        {
            return new BangladeshiWaterResource(point);
        }
    }
}
