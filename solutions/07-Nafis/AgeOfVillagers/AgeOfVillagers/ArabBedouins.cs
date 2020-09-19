using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;

namespace AgeOfVillagers
{
    class ArabBedouins : INations
    {

        Pen pen = new Pen(Color.Black);
        
        public void DrawHouse(int x, int y, Graphics g)
        {
            Point[] triangle = { new Point(x, y), new Point(x - 20, y + 25), new Point(x + 20, y + 25) };
            //Point[] rectangle = { new Point(x, y), new Point(x + 14, y + 14), new Point(x + 24, y + 29), new Point(x + 20, y + 25) };
            g.DrawPolygon(pen, triangle);
            g.DrawLine(pen, new Point(x, y), new Point(x + 12, y - 12));
            g.DrawLine(pen, new Point(x + 12, y - 12), new Point(x + 32, y + 13));
            g.DrawLine(pen, new Point(x + 20, y + 25), new Point(x + 32, y + 13));
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(x, y), new Point(x, y - 30)); //mid
            g.DrawLine(pen, new Point(x, y), new Point(x - 13, y - 22)); //mid left
            g.DrawLine(pen, new Point(x, y), new Point(x - 18, y - 13)); //left
            g.DrawLine(pen, new Point(x, y), new Point(x + 11, y - 22)); //mid right
            g.DrawLine(pen, new Point(x, y), new Point(x + 25, y - 22)); //right

            g.DrawRectangle(pen, x - 2, y, 4, 30);

        }

        public void DrawWater(int x, int y, Graphics g)
        {
            g.DrawLine(pen, new Point(10, 10), new Point(10, 10));
        }
    }
}
