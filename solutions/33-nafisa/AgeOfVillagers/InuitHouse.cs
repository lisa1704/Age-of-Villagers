using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHouse : CompositeShape
    {
       // private Panel Drawingpanel;

        public InuitHouse(Point point)
        {
            addshape(new Arc(point.X, point.Y, 24, 24, 0, -180));
            addshape(new Arc(point.X + 8, point.Y + 7, 8, 8, 0, -180));
            addshape(new Line(point.X, point.Y + 12, point.X + 24, point.Y + 12));
        }
        
    }
}
