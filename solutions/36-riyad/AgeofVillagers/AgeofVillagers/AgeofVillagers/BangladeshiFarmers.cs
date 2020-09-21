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
            BangladeshiHouse house = new BangladeshiHouse(new Point(pt.X, pt.Y), new Point(pt.X - 50, pt.Y + 25), new Point(pt.X + 50, pt.Y + 50));
            house.Paint(g, pen);
            return "KureGhor";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }

        public Color TerrainColor()
        {

            return System.Drawing.Color.Green;
        }
    }
}
