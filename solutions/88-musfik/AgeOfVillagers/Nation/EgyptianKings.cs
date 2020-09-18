using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        private readonly Color color = Color.Yellow;
        private String nation_name = "Egyptian Kings";

        public EgyptianKings()
        {
            
        }

        public string nationName { get => nation_name; set => nation_name = value; }

        public House getHouse(Point point)
        {
            return new EgyptianHouse(point);
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
            return new EgyptianTree(point);
        }

        public WaterResource getWaterResource(Point point)
        {
            return new EgyptianWaterResource(point);
        }
    }
}
