using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Components;


namespace Age_of_villagers.Nations
{
    class BangladeshiFarmers : INation
    {
        public string getNationName()
        {
            return "Bangladeshi Farmers";
        }

        public Color getTerrainColor()
        {
            return Color.Green;
        }
        public VillageComponent getHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }

        public VillageComponent getTree(Point point)
        {
            return new BangladeshiTree(point);
        }

        public VillageComponent getWaterSource(Point point)
        {
            return new BangladeshiWaterSource(point);
        }
    }
}
