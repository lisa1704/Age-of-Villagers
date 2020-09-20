using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Age_of_Villagers
{
    public class NullNation : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            NullElements NullHouse = new NullElements();
            NullHouse.drawing();
        }

        public void DrawTree(Graphics g, Point point)
        {
            NullElements NullTree = new NullElements();
            NullTree.drawing();
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullElements NullWaterSource = new NullElements();
            NullWaterSource.drawing();
        }
    }
}
