using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        Color getTerrainColor();
        string getNationName();
        Object getTree(Point point);
        Object getHouse(Point point);
        Object getWaterResource(Point point);
    }

    public class BangladeshiFarmers : INation
    {
        public object getHouse(Point point)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColor()
        {
            throw new NotImplementedException();
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
