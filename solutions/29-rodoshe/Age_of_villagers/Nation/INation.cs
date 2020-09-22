using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.VillageComponents;

namespace Age_of_Villagers.Nation
{

    public interface INation
    {
        string getNationName();
        Color BgColor();
        void DrawHouse();

        void DrawTree();

        void DrawWaterSource();
        VillageComponents.VillageComponents getHouse(Point p);
        VillageComponents.VillageComponents getTree(Point p);
        VillageComponents.VillageComponents getWaterSource(Point p);
    }
}
