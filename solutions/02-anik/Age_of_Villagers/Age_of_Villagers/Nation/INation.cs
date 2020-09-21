using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_villagers.Components;

namespace Age_of_Villagers.Nation
{
    interface INation
    {
        public interface INation
        {
            string getNationName();
            Color BgColor();
            void DrawHouse();

            void DrawTree();

            void DrawWaterSource();
            VillageComponents GetHouse(Point p);
            VillageComponents getTree(Point p);
            VillageComponents getWaterSource(Point p);
        }
    }
}
