using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabBedouins : INations
    {

        Pen pen = new Pen(Color.Black);
        
        public void DrawHouse(int x, int y, Graphics g)
        {
            Point[] points = { new Point(x, y), new Point(x + 15, y + 6), new Point(x + 20, y - 3), new Point(x + 9, y - 12) };
            g.DrawPolygon(pen, points);
            g.DrawLine(pen, new Point(x + 15, y + 6), new Point(x + 9, y - 12));
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            throw new NotImplementedException();
        }

        public void DrawWater(int x, int y, Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
