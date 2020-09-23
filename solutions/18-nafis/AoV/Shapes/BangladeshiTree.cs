using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class BangladeshiTree : ComposeShape
    {

        private Point p1, p2;
        private float ellHeight, height, width;

        public BangladeshiTree(Point p1, Point p2)
        {

            this.p1 = p1;
            this.p2 = p2;
            this.width = p2.X - p1.X;
            this.height = p2.Y - p1.Y;
            this.ellHeight = (float)(height * .75);

            AddShape(new Ellipse(p1,new Point(p2.X, (int)(p1.Y+ellHeight))));
            AddShape(new Rectangle(new Point((int)(p1.X + width/2 -1), (int)(p1.Y + height/2)), new Point((int)(p1.X + width/2 +1), p2.Y)));
        }

    }
}
