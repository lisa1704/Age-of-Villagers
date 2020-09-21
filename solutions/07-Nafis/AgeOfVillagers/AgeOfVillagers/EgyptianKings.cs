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
            g.DrawLine(pen, new Point(x, y), new Point(x + 15, y + 6));
            g.DrawLine(pen, new Point(x, y), new Point(x + 9, y - 12));
            g.DrawLine(pen, new Point(x + 15, y + 6), new Point(x + 20, y - 3));
            g.DrawLine(pen, new Point(x + 9, y - 12), new Point(x + 20, y - 3));
            g.DrawLine(pen, new Point(x + 14, y + 5), new Point(x + 9, y - 12));
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x - 6, y - 10)); //left mid
            g.DrawLine(pen, new Point(x, y), new Point(x - 13, y - 8)); //left left
            g.DrawLine(pen, new Point(x, y), new Point(x + 7, y - 12)); //left right
            g.DrawLine(pen, new Point(x, y), new Point(x + 12, y + 20)); //left main
            g.DrawLine(pen, new Point(x + 22, y + 4), new Point(x + 12, y + 20)); //right main
            g.DrawLine(pen, new Point(x + 22, y + 4), new Point(x + 28, y - 7)); //right mid
            g.DrawLine(pen, new Point(x + 22, y + 4), new Point(x + 18, y - 7)); //right left
            g.DrawLine(pen, new Point(x + 22, y + 4), new Point(x + 36, y - 8)); //right right
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
