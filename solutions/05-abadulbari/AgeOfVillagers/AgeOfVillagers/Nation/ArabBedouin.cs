using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    public class ArabBedouin : INation
    {
        public VillageItem getHouse(Point point)
        {
            return new ArabianHouse(point);
        }

        public string getNationName()
        {
            return "Arab Bedouin";
        }

        public Color getTerrainColor()
        {
            return Color.LightYellow;
        }

        public VillageItem getTree(Point point)
        {
            return new ArabianTree(point);
        }

        public VillageItem getWaterSource(Point point)
        {
            return new NullItem(point);
        }
    }
}
