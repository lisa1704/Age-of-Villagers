using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class EgyptianKingsHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X,axis.Y), new PointF(axis.X +10, axis.Y + 15));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X -10, axis.Y +11));

            graphics.DrawLine(pen, new PointF(axis.X +10, axis.Y + 15), new PointF(axis.X - 4, axis.Y + 20));
            graphics.DrawLine(pen, new PointF(axis.X -10, axis.Y +11), new PointF(axis.X - 4, axis.Y + 20));

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 4, axis.Y + 20));
        }
    }
}
