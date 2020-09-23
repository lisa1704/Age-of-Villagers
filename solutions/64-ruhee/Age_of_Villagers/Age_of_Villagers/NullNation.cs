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

        public IShape DrawHouse(Graphics g, Point point)
        {
            NullElements NullHouse = new NullElements();
            return (NullHouse);
        }

        public IShape DrawTree(Graphics g, Point point)
        {
            NullElements NullTree = new NullElements();
            return (NullTree);
        }

        public IShape DrawWaterSource(Graphics g, Point point)
        {
            NullElements NullWaterS = new NullElements();
            return (NullWaterS);
        }
    }
}
