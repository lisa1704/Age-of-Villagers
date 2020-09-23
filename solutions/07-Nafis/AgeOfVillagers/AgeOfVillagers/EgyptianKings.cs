using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class EgyptianKings : INations
    {
        Pen pen = new Pen(Color.Black);
        MainWindow mw = new MainWindow();
        
        public void DrawHouse(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x + 10, y + 5));
            g.DrawLine(pen, new Point(x, y), new Point(x + 5, y - 11));
            g.DrawLine(pen, new Point(x + 10, y + 5), new Point(x + 16, y - 2));
            g.DrawLine(pen, new Point(x + 5, y - 11), new Point(x + 16, y - 2));
            g.DrawLine(pen, new Point(x + 10, y + 5), new Point(x + 5, y - 11));
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x - 1, y - 10)); //left mid
            g.DrawLine(pen, new Point(x, y), new Point(x - 4, y - 9)); //left left
            g.DrawLine(pen, new Point(x, y), new Point(x + 3, y - 11)); //left right
            g.DrawLine(pen, new Point(x, y), new Point(x + 4, y + 13)); //left main
            g.DrawLine(pen, new Point(x + 8, y + 1), new Point(x + 4, y + 13)); //right main
            g.DrawLine(pen, new Point(x + 8, y + 1), new Point(x + 11, y - 9)); //right mid
            g.DrawLine(pen, new Point(x + 8, y + 1), new Point(x + 7, y - 9)); //right left
            g.DrawLine(pen, new Point(x + 8, y + 1), new Point(x + 16, y - 10)); //right right
        }

        public void DrawWater(int x, int y, Graphics g)
        {
            g.DrawArc(pen, x - 6, y - 6, 12, 12, 0, 360);
        }

        public Color SetColor()
        {
            return Color.Yellow;
        }
    }
}
