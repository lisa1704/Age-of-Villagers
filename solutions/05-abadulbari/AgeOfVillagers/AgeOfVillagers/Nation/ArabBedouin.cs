using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    class ArabBedouin : INation
    {
        public VillageItem getHouse(Point point)
        {
            return new ArabianHouse(point);
        }

        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColor()
        {
            return Color.LightYellow;
        }

        public VillageItem getTree(Point p)
        {
            throw new NotImplementedException();
        }

        public VillageItem getWaterSource(Point p)
        {
            throw new NotImplementedException();
        }
    }
}
