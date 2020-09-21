using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class InuitHunters : INations
    {
        Pen pen = new Pen(Color.Black);
        MainWindow mw = new MainWindow();
        
        public void DrawHouse(int x, int y, Graphics g)
        {
            g.DrawArc(pen, x, y - 30, 60, 60, 180, 180);
            g.DrawLine(pen, new Point(x, y), new Point(x + 60, y));
            g.DrawArc(pen, x + 20, y - 10, 20, 20, 180, 180);
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(10, 10), new Point(10, 10));
        }

        public void DrawWater(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(10, 10), new Point(10, 10));
        }

        public Color SetColor()
        {
            return Color.White;
        }
    }
}
