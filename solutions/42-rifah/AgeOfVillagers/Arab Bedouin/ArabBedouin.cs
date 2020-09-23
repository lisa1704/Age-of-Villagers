using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouin : INation
    {
        public Color BackgroundColor()
        {

            return Color.GreenYellow;
        }

        public Object DrawHouse(Graphics g, Point point)
        {
            ArabBedouinHouse arabBedouinHouse = new ArabBedouinHouse(point);
            arabBedouinHouse.Draw(g);
            return arabBedouinHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        {
            ArabBedouinTrees arabBedouinTree = new ArabBedouinTrees(point);
            arabBedouinTree.Draw(g);
            return arabBedouinTree;
        }

        public Object DrawWaterSource(Graphics g, Point point)
        {
            NullItems arabBedouinWaterSource = new NullItems();
            arabBedouinWaterSource.drawing();
            return arabBedouinWaterSource;
        }
    }
}
