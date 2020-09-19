using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INations
    {
        
        
        Pen pen = new Pen(Color.Black, 2);
        public void DrawHouse(int x, int y, Graphics g)
        {

            Point[] points = { new Point(x - 1, y), new Point(x + 15, y - 10), new Point(x + 30, y) };
            g.DrawRectangle(pen, x, y, 30, 15);
            g.DrawPolygon(pen, points);
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            g.DrawEllipse(pen, x - 15, y - 20, 30, 40);
            g.DrawRectangle(pen, x, y, 2, 30);

        }

        public void DrawWater(int x, int y, Graphics g)
        {
            Point[] points = { new Point(x, y), new Point(x + 8, y + 6), new Point(x + 16, y), new Point(x + 21, y + 5), new Point(x + 24, y - 4), new Point(x + 18, y - 10), new Point(x + 13, y - 4), new Point(x + 12, y - 9), new Point(x + 9, y - 8) };
            g.DrawPolygon(pen, points);
        }

        
        
        

        
    }
}
