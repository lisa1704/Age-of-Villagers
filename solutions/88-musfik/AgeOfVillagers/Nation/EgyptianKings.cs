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

        public object getHouse(Point point)
        {
            return new EgyptianHouseShape(point);
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
            return new EgyptianTreeShape(point);
        }

        public object getWaterResource(Point point)
        {
            return new EgyptianWaterSourceShape(point);
        }
    }
}
