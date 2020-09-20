using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    class EgyptianKings : INation
    {
        public VillageItem getHouse(Point point)
        {
            return new EgyptianHouse(point);
        }

        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColor()
        {
            return Color.Yellow;
        }

        public VillageItem getTree(Point p)
        {
            return new EgyptianTree(p);
        }

        public VillageItem getWaterSource(Point p)
        {
            throw new NotImplementedException();
        }
    }
}
