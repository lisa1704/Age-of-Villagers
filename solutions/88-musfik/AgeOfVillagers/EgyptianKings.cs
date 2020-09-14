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

    public class EgyptianKingsHouse : CompositeShape
    {
        public EgyptianKingsHouse(Point point)
        {
            
        }
    }
}
