using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using Age_of_villagers.Components;

namespace Age_of_villagers.Nation
{
    public interface INation
    {
        string getNationName();
        Color getTerrainColor();
        VillageComponent getHouse(Point p);
        VillageComponent getTree(Point p);
        VillageComponent getWaterSource(Point p);
    }
}
