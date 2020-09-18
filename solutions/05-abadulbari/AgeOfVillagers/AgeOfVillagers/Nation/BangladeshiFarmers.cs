﻿using AgeOfVillagers.Shapes;
using AgeOfVillagers.VillegeItems;
using System.Drawing;

namespace AgeOfVillagers.Nation
{
    public class BangladeshiFarmers : INation
    {
        public string getNationName()
        {
            return "Bangladeshi Farmers";
        }

        public Color getTerrainColor()
        {
            return Color.Green;
        }
        public IShape getHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }
    }
}
