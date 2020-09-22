using Age_of_Villagers.VillageComponents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers.Nation
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
