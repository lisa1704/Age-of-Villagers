using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers.VillegeItems
{
    class BangladeshiTree : IShape
    {
        private readonly Point topLeft, bottomRight, centre;

        public BangladeshiTree(Point point)
        {
            centre = point;
            topLeft.X = point.X - 20;
            topLeft.Y = point.Y - 20;
            bottomRight.X = point.X + 20;
            bottomRight.Y = point.Y + 20;
        }

        public void draw(Graphics g, Pen p)
        {
            new Circle(topLeft, bottomRight).draw(g, p);
            new Rectangle(new Point(centre.X - 2, centre.Y), new Point(centre.X + 2, centre.Y + 40)).draw(g, p);
        }
    }
}
