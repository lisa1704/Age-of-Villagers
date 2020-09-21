using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingTree : CompositeShapes
    {
        private Point point;
        public EgyptianKingTree(Point point)
        {
            Point p1 = point;
            Point topright = new Point(p1.X + 16, p1.Y - 16);
            Point topleft = new Point(p1.X - 16, p1.Y - 16);
            Point midright = new Point(p1.X + 11, p1.Y - 11);
            Point midleft = new Point(p1.X - 11, p1.Y - 11);
            Point br1 = new Point(p1.X + 16, p1.Y - 11);
            Point br2 = new Point(p1.X + 12, p1.Y - 16);
            Point bl1 = new Point(p1.X - 16, p1.Y - 11);
            Point bl2 = new Point(p1.X - 12, p1.Y - 16);

            addshapes(new Line(p1, topleft));
            addshapes(new Line(p1, topright));
            addshapes(new Line(midright, br1));
            addshapes(new Line(midright, br2));
            addshapes(new Line(midleft, bl1));
            addshapes(new Line(midleft, bl2));
        }

        
    }
}
