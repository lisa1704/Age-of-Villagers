﻿using System.Drawing;

namespace ageOfVillagers
{
    internal class Line
    {
        private int x1, y1, x2, y2;
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, x1, y1, x2, y2);
            //return "Drawing a line. ";
        }
    }
}