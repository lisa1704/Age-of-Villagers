using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    class InuitHunters : INation
    {
        public VillageItem getHouse(Point point)
        {
            return new InuitHouse(point);
        }

        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColor()
        {
            return Color.White;
        }

        public VillageItem getTree(Point point)
        {
            return new NullItem(point);
        }

        public VillageItem getWaterSource(Point point)
        {
            return new NullItem(point);
        }
    }
}
