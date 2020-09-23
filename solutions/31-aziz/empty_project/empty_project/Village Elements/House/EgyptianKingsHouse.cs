using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class EgyptianKingsHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X,axis.Y), new PointF(axis.X + 8, axis.Y + 14));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 8, axis.Y + 12));

            graphics.DrawLine(pen, new PointF(axis.X + 8, axis.Y + 14), new PointF(axis.X - 2, axis.Y + 16));
            graphics.DrawLine(pen, new PointF(axis.X - 8, axis.Y + 12), new PointF(axis.X - 2, axis.Y + 16));

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 2, axis.Y + 16));
        }
    }
}
