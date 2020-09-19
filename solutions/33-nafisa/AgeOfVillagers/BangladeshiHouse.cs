using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BangladeshiHouse : CompositeShape
    {
        private Panel Drawingpanel;
        //private Point point;
        public BangladeshiHouse(Point point,Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;

            addshape(new Line(point.X, point.Y, point.X + 24, point.Y));
            addshape(new Line(point.X + 24, point.Y, point.X + 24, point.Y + 16));
            addshape(new Line(point.X, point.Y + 16, point.X + 24, point.Y + 16));
            addshape(new Line(point.X, point.Y, point.X, point.Y + 16));
            addshape(new Line(point.X, point.Y, point.X + 12, point.Y - 8));
            addshape(new Line(point.X + 24, point.Y, point.X + 12, point.Y - 8));
        }

        /*public new void Draw(Point point, Panel Drawingpanel)
        {
           // g.DrawLine(p, point.X, point.Y, point.X + 24, point.Y);
           // g.DrawLine(p, point.X + 24, point.Y, point.X + 24, point.Y + 16);
           // g.DrawLine(p, point.X, point.Y + 16, point.X + 24, point.Y + 16);
           // g.DrawLine(p, point.X, point.Y, point.X, point.Y + 16);
           // g.DrawLine(p, point.X, point.Y, point.X + 12, point.Y-8);
           // g.DrawLine(p, point.X + 24, point.Y, point.X + 12, point.Y - 8);
        }*/
    }
}
