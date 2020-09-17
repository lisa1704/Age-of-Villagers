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

        public object getHouse(Point point)
        {
            return new BangladeshiHouseShape(point);
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
            return new BangladeshiTreeShape(point);
        }

        public object getWaterResource(Point point)
        {
            return new BangladeshiWaterSourceShape(point);
        }
    }
}
