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
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColor()
        {
            return Color.White;
        }

        public VillageItem getTree(Point pointp)
        {
            throw new NotImplementedException();
        }

        public VillageItem getWaterSource(Point pointp)
        {
            throw new NotImplementedException();
        }
    }
}
