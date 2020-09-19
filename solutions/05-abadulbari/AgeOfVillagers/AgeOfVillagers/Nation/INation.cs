using AgeOfVillagers.Shapes;
using AgeOfVillagers.VillegeItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    public interface INation
    {
        string getNationName();
        Color getTerrainColor();
        VillageItem getHouse(Point p);
        VillageItem getTree(Point p);
        VillageItem getWaterSource(Point p);
    }
}
