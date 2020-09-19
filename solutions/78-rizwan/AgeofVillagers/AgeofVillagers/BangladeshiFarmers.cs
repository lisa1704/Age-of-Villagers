using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    class BangladeshiFarmers : Ination
    {
        public int x, y, w, h;
        Pen p = new Pen(Color.Red, 3);
        public void createHouse()
        {
            Point v1, v2, v3;
            Form1 frm1 = new Form1();
            Graphics g = frm1.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            g.DrawRectangle(p, shape);
            v1 = new Point(x, y);
            v2 = new Point((x + w) / 2, y + 5);
            v3 = new Point(w, h);
            Point[] vertices = { v1, v2, v3 };
            g.DrawPolygon(p, vertices);
        }

        public void createTree()
        {
               
        }

        public void createWaterSource()
        {
            
        }
    }
}
