using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_villagers.Components;
using Age_of_villagers.Nation;

namespace Age_of_villagers.Nations
{
    class ArabBeduin : INation
    {
        public VillageComponent getHouse(Point p)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            return "Arab Beduins";
        }

        public Color getTerrainColor()
        {
            return Color.LightYellow;
        }

        public VillageComponent getTree(Point p)
        {
            throw new NotImplementedException();
        }

        public VillageComponent getWaterSource(Point p)
        {
            throw new NotImplementedException();
        }
    }

}