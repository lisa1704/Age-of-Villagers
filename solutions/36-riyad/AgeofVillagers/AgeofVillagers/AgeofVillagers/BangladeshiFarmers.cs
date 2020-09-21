using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class BangladeshiFarmers : INation
    {
        Pen pen = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point pt)
        {
            BangladeshiHouse house = new BangladeshiHouse(new Point(pt.X, pt.Y), new Point(pt.X - 50, pt.Y * 5), new Point(pt.X + 50, pt.Y * 10));
            house.Paint(g, pen);
            return "KureGhor";
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
