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

        public object getHouse(Point point)
        {
            return new InuitHuntersHouseShape(point);
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
            return new NullShape(point);
        }

        public object getWaterResource(Point point)
        {
            return new NullShape(point);
        }
    }
}
