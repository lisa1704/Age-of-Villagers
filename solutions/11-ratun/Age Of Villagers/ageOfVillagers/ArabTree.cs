﻿using System.Drawing;

namespace ageOfVillagers
{
    internal class ArabTree : IShape
    {
        Pen p = new Pen(Color.LightYellow);
        public string draw(int x, int y, Graphics g)
        {
            Rectangle r = new Rectangle(g,p,x - 1, y, x - 1, y - 12, x + 1, y - 12, x + 1, y);
            r.Draw();
            Line l1 = new Line(x, y, x - 8, y + 4);
            l1.Draw(g,p);
            Line l2 = new Line(x, y, x - 4, y + 8);
            l2.Draw(g, p);
            Line l3 = new Line(x, y, x, y + 12);
            l3.Draw(g, p);
            Line l4 = new Line(x, y, x + 4, y + 8);
            l4.Draw(g, p);
            Line l5 = new Line(x, y, x + 8, y + 4);
            l5.Draw(g, p);
            return "Drawing Arab Tree";
        }
    }
}