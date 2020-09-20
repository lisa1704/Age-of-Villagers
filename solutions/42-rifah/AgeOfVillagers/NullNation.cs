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
            throw new NotImplementedException();
        }

        public void DrawHouse(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
