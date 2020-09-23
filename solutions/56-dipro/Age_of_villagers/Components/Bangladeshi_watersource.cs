using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Shape;

namespace Age_of_villagers.Components
{
    class Bangladeshi_watersource : VillageComponent
    {
        private readonly Point p1, p2, p3, p4, p5, p6, p7, p8, p9;

        public Bangladeshi_watersource(Point point)
        {
            p1 = point;
            p2 = new Point(point.X + 6, point.Y - 6);
            p3 = new Point(point.X + 12, point.Y - 7);
            p4 = new Point(point.X + 13, point.Y - 1);
            p5 = new Point(point.X + 18, point.Y - 8);
            p6 = new Point(point.X + 24, point.Y - 1);
            p7 = new Point(point.X + 20, point.Y + 7);
            p8 = new Point(point.X + 15, point.Y + 4);
            p9 = new Point(point.X + 8, point.Y + 8);
            AddComp(new Line(p1, p2));
            AddComp(new Line(p2, p3));
            AddComp(new Line(p3, p4));
            AddComp(new Line(p4, p5));
            AddComp(new Line(p5, p6));
            AddComp(new Line(p6, p7));
            AddComp(new Line(p7, p8));
            AddComp(new Line(p8, p9));
            AddComp(new Line(p9, p1));
        }
    }
}
