using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void DrawTree(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
        public void DrawHouse(Graphics g, Point point)
        {
            g.DrawLine(p, point.X, point.Y, 100, 100);
            Rectangle rectangle = new Rectangle(new Point(point.X, point.Y), new Point(point.X + 15, point.Y + 25));
            rectangle.Draw(g);
        }
        public void DrawWaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
