﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Components;

namespace Age_of_villagers.Nation
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
            return new Bangladeshi_house(point);
        }

        public VillageComponent getTree(Point point)
        {
            return new Bangladeshi_tree(point);
        }

        public VillageComponent getWaterSource(Point point)
        {
            return new Bangladeshi_watersource(point);
        }
    }

}