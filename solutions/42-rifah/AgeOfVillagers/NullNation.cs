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

        public Object DrawHouse(Graphics g, Point point)
        {
            NullItems NullHouse = new NullItems();
            NullHouse.drawing();
            return NullHouse;
        }

        public Object DrawTree(Graphics g, Point point)
        {
            NullItems NullTree = new NullItems();
            NullTree.drawing();
            return NullTree;
        }

        public Object DrawWaterSource(Graphics g, Point point)
        {
            NullItems NullWaterSource = new NullItems();
            NullWaterSource.drawing();
            return NullWaterSource;
        }
    }
}
