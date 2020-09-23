using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianTree : CompositeShapes
    {
        private Point pl, pr,pl1,pl2, pl3, pr1, pr2, pr3;
        public EgyptianTree(Point p)
        {
            pl = new Point(p.X - 20, p.Y - 25);
            pr = new Point(p.X + 20, p.Y - 25);
            add_shapes(new Line(p, pl));
            add_shapes(new Line(p, pr));

            pl1 = new Point(pl.X + 16, pl.Y - 12);
            pl2 = new Point(pl.X - 16, pl.Y - 12);
            pl3 = new Point(pl.X, pl.Y - 16);
            add_shapes(new Line(pl, pl1));
            add_shapes(new Line(pl, pl2));
            add_shapes(new Line(pl, pl3));

            pr1 = new Point(pr.X + 16, pr.Y - 12);
            pr2 = new Point(pr.X - 16, pr.Y - 12);
            pr3 = new Point(pr.X, pr.Y - 12);
            add_shapes(new Line(pr, pr1));
            add_shapes(new Line(pr, pr2));
            add_shapes(new Line(pr, pr3));

            

        }
    }
}

