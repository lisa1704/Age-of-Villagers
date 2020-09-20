using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class NullNation : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            NullItems NullHouse = new NullItems();
            NullHouse.drawing();
        }

        public void DrawTree(Graphics g, Point point)
        {
            NullItems NullTree = new NullItems();
            NullTree.drawing();
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullItems NullWaterSource = new NullItems();
            NullWaterSource.drawing();
        }
    }
}
