using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        private readonly Color color = Color.White;
        private String nation_name = "Inuit Hunters";

        public InuitHunters()
        {
        
        }

        public string nationName { get => nation_name; set => nation_name = value; }

        public House getHouse(Point point)
        {
            return new InuitHuntersHouse(point);
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
            return new NoTree(point);
        }

        public WaterResource getWaterResource(Point point)
        {
            return new NoWaterResource(point);
        }
    }
}
