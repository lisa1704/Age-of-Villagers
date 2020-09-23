using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Egyptian_Kings
{
    public class EgyptianKings : INation
    {
        public Color BackgroundColor()
        {
            return Color.Yellow;
        }

        public Object DrawHouse(Graphics g, Point point)
        {
            EgyptianKingsHouse egyptianHouse = new EgyptianKingsHouse(point);
            egyptianHouse.Draw(g);
            return egyptianHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        {
            EgyptianKingsTrees egyptianTrees = new EgyptianKingsTrees(point);
            egyptianTrees.Draw(g);
            return egyptianTrees;
        }

        public Object DrawWaterSource(Graphics g, Point point)
        {
            EgyptianKingsWatersource egyptianWaterSource = new EgyptianKingsWatersource(point);
            egyptianWaterSource.Draw(g);
            return egyptianWaterSource;
        }
    }
}
