﻿using System.Drawing;

namespace ageOfVillagers
{
    internal class Bdwater : IShape
    {
        private int xLength = 24;
        private int yLength = 16;
        Pen pen = new Pen(Color.Green);
        public string draw(Graphics g, int x, int y)
        {
            Line l1 = new Line(pen,x - 12, y, x - 6, y + 6);
            Line l2 = new Line(pen,x - 6, y + 6, x - 2, y + 7);
            Line l3 = new Line(pen, x - 2, y + 7, x - 1, y + 3);
            Line l4 = new Line(pen, x - 1, y + 3, x + 6, y + 8);
            Line l5 = new Line(pen, x + 6, y + 8, x + 12, y + 2);
            Line l6 = new Line(pen, x + 12, y + 2, x + 5, y - 7);
            Line l7 = new Line(pen, x + 5, y - 7, x - 1, y - 2);
            Line l8 = new Line(pen, x - 1, y - 2, x - 6, y + 8);
            Line l9 = new Line(pen, x - 6, y + 8, x - 12, y);
            return "Drawing BD water";
        }
    }
}