using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.VillegeItems
{
    class BangladeshiWaterSource : VillageItem
    {
        private readonly Point point1, point2, point3, point4, point5, point6, point7, point8;

        public BangladeshiWaterSource(Point point)
        {
            point1 = point;
            point2 = new Point(point.X, point.Y+20);
            point3 = new Point(point.X+30, point.Y);
            point4 = new Point(point.X+50, point.Y+20);
            point5 = new Point(point.X+45, point.Y+45);
            point6 = new Point(point.X+25, point.Y+33);
            point7 = new Point(point.X, point.Y+45);
            point8 = new Point(point.X-30, point.Y+33);
            addItem(new Line(point1, point2));
            addItem(new Line(point2, point3));
            addItem(new Line(point3, point4));
            addItem(new Line(point4, point5));
            addItem(new Line(point5, point6));
            addItem(new Line(point6, point7));
            addItem(new Line(point7, point8));
            addItem(new Line(point8, point1));
        }
        public override void draw(Graphics g, Pen p)
        {
            new Line(point1, point2).draw(g, p);
            new Line(point2, point3).draw(g, p);
            new Line(point3, point4).draw(g, p);
            new Line(point4, point5).draw(g, p);
            new Line(point5, point6).draw(g, p);
            new Line(point6, point7).draw(g, p);
            new Line(point7, point8).draw(g, p);
            new Line(point8, point1).draw(g, p);
        }
    }
}
