using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Egyptian_Kings
{
    class EgyptianKings : INation
    {
        public void DrawHouse(Graphics g, Point point)
        {
            EgyptianKingsHouse egyptianHouse = new EgyptianKingsHouse(point);
            egyptianHouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point point)
        {
            EgyptianKingsTrees egyptianTrees = new EgyptianKingsTrees(point);
            egyptianTrees.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            EgyptianKingsWatersource egyptianWaterSource = new EgyptianKingsWatersource(point);
            egyptianWaterSource.Draw(g);
        }
    }
}
