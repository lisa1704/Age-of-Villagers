using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
       Pen pen = new Pen(Color.Black, 3);

        public void DrawHouse(Graphics g, int X, int Y)
        {
            g.DrawLine(pen, new Point(X, Y), new Point(X+100,Y));
        }

        public void DrawTrees(Graphics g, int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSources(Graphics g, int X, int Y)
        {
            throw new NotImplementedException();
        }
    }
}
