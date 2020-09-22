using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    public class EgyptianKings : INation
    {
        public VillageItem getHouse(Point point)
        {
            return new EgyptianHouse(point);
        }

        public string getNationName()
        {
            return "Egyptian Kings";
        }

        public Color getTerrainColor()
        {
            return Color.Yellow;
        }

        public VillageItem getTree(Point point)
        {
            return new EgyptianTree(point);
        }

        public VillageItem getWaterSource(Point point)
        {
            return new EgyptianWaterSource(point);
        }
    }
}
