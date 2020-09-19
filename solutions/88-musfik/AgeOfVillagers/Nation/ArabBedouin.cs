using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
        private readonly Color color = Color.LightGoldenrodYellow;
        private String nation_name = "Arab Bedouin";

        public ArabBedouin()
        {
            
        }

        public string nationName { get => nation_name; set => nation_name = value; }

        public House getHouse(Point point)
        {
            return new ArabHouse(point);
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
            return new ArabTree(point);
        }

        public WaterResource getWaterResource(Point point)
        {
            return new NoWaterResource(point);
        }
    }
}
