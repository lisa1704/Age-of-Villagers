using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers.VillegeItems
{
    class BangladeshiHouse : IShape
    {
        private readonly Point top, midLeft, midRight, bottomLeft, bottomRight;

        public BangladeshiHouse(Point point) {
            top = point;
            midLeft = new Point(top.X-10, top.Y+20);
            midRight = new Point(top.X+10, top.Y+20);
            bottomLeft = new Point(top.X-10, top.Y+40);
            bottomRight = new Point(top.X+10, top.Y+40);
        }
        public void draw(Graphics g, Pen p)
        {
            new Triangle(top, midLeft, midRight).draw(g, p);
            new Rectangle(midLeft, midRight, bottomLeft, bottomRight).draw(g, p);
        }


    }
}
