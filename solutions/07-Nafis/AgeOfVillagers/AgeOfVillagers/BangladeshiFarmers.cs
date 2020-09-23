using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INations
    {
        
        Pen pen = new Pen(Color.Black, 1);
        MainWindow mw = new MainWindow();

        public void DrawHouse(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x + 8, y - 6));
            g.DrawLine(pen, new Point(x, y), new Point(x + 16, y));
            g.DrawLine(pen, new Point(x + 8, y - 6), new Point(x + 16, y));
            g.DrawLine(pen, new Point(x, y), new Point(x, y + 10));
            g.DrawLine(pen, new Point(x + 16, y), new Point(x + 16, y + 10));
            g.DrawLine(pen, new Point(x, y + 10), new Point(x + 16, y + 10));
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            g.DrawArc(pen, x - 8, y - 9, 16, 18, 0, 360);
            g.DrawLine(pen, new Point(x - 1, y), new Point(x + 1, y));
            g.DrawLine(pen, new Point(x - 1, y), new Point(x - 1, y + 15));
            g.DrawLine(pen, new Point(x + 1, y), new Point(x + 1, y + 15));
            g.DrawLine(pen, new Point(x - 1, y + 15), new Point(x + 1, y + 15));
        }

        public void DrawWater(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x + 8, y + 6));
            g.DrawLine(pen, new Point(x + 8, y + 6), new Point(x + 16, y));
            g.DrawLine(pen, new Point(x + 16, y), new Point(x + 21, y + 5));
            g.DrawLine(pen, new Point(x + 21, y + 5), new Point(x + 24, y - 4));
            g.DrawLine(pen, new Point(x + 24, y - 4), new Point(x + 18, y - 10));
            g.DrawLine(pen, new Point(x + 18, y - 10), new Point(x + 13, y - 4));
            g.DrawLine(pen, new Point(x + 13, y - 4), new Point(x + 12, y - 9));
            g.DrawLine(pen, new Point(x + 12, y - 9), new Point(x + 9, y - 8));
            g.DrawLine(pen, new Point(x + 9, y - 8), new Point(x, y));

        }

        public Color SetColor()
        {
            return Color.Green;
        }
    }
}
