using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Inuit_Hunters

{
    class InuitHunters : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            InuitHuntersHouse inuitHunterHouse = new InuitHuntersHouse(point);
            inuitHunterHouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point point)
        {
            NullItems inuitHunterTree = new NullItems();
            inuitHunterTree.drawing();
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullItems inuitHunterWaterSource = new NullItems();
            inuitHunterWaterSource.drawing();
        }
    }
}
