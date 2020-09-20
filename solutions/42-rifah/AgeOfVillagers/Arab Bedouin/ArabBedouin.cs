using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Arab_Bedouin
{
    class ArabBedouin : INation
    {
        public Color BackgroundColor()
        {

            return Color.GreenYellow;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            ArabBedouinHouse arabBedouinHouse = new ArabBedouinHouse(point);
            arabBedouinHouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point point)
        {
            ArabBedouinTrees arabBedouinTree = new ArabBedouinTrees(point);
            arabBedouinTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullItems NullWaterSource = new NullItems();
            NullWaterSource.drawing();
        }
    }
}
