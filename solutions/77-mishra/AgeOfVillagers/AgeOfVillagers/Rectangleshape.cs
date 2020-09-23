using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Rectangleshape : CompositeShapes
    {
        /*private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;*/

        public Rectangleshape(Point p1, Point p2, Point p3, Point p4)
        {
            addshapes(new Line(p1, p2));
            addshapes(new Line(p2, p3));
            addshapes(new Line(p1, p4));
            addshapes(new Line(p3, p4));

        }
    }
}
