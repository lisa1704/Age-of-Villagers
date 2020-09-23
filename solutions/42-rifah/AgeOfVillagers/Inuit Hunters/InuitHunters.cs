using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Inuit_Hunters

{
    public class InuitHunters : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public Object DrawHouse(Graphics g, Point point)
        {
            InuitHuntersHouse inuitHunterHouse = new InuitHuntersHouse(point);
            inuitHunterHouse.Draw(g);
            return inuitHunterHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        {
            NullItems inuitHunterTree = new NullItems();
            inuitHunterTree.drawing();
            return inuitHunterTree;
        }

        public Object DrawWaterSource(Graphics g, Point point)
        {
            NullItems inuitHunterWaterSource = new NullItems();
            inuitHunterWaterSource.drawing();
            return inuitHunterWaterSource;
        }
    }
}
