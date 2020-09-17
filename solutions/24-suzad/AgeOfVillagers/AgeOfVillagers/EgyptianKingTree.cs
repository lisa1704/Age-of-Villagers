﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingTree : VillageComponent
    {
        public Point e;
        public EgyptianKingTree(Point e)
        {
            this.e = e;

            Point point1 = new Point(e.X, e.Y);
            Point point2 = new Point(e.X+3, e.Y-12);
            Point point3 = new Point(e.X-2, e.Y-12);
            Point point4 = new Point(e.X+8, e.Y-24);
            Point point5 = new Point(e.X+5, e.Y-24);
            Point point6 = new Point(e.X+2, e.Y-24);
            Point point7 = new Point(e.X-1, e.Y-24);
            Point point8 = new Point(e.X-4, e.Y-24);
            Point point9 = new Point(e.X-8, e.Y-24);

            addComponent(new Line(point1, point5));
            addComponent(new Line(point1, point8));
            addComponent(new Line(point2, point4));
            addComponent(new Line(point2, point6));
            addComponent(new Line(point3, point7));
            addComponent(new Line(point3, point9));
        }
        /*public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawLine(pen, x, y, x + 3, y - 12);
            graphics.DrawLine(pen, x, y, x - 2, y - 12);
            graphics.DrawLine(pen, x + 3, y - 12, x + 8, y - 24);
            graphics.DrawLine(pen, x + 3, y - 12, x + 5, y - 24);
            graphics.DrawLine(pen, x + 3, y - 12, x + 2, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 8, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 4, y - 24);
            graphics.DrawLine(pen, x - 2, y - 12, x - 1, y - 24);
        }*/

        public override Point getPoint()
        {
            return e;
        }
    }
}
