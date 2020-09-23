using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_villagers.Components;
using Age_of_villagers.Nation;

namespace Age_of_villagers.Nations
{
    class InuitHunters : INation
    {
        public VillageComponent getHouse(Point p)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            return "Inuit Hunter";
        }

        public Color getTerrainColor()
        {
            return Color.White;
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