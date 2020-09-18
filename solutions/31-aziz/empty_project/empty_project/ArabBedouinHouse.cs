using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class ArabBedouinHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 5, axis.Y -10));
            graphics.DrawLine(pen, new PointF(axis.X - 5, axis.Y -10), new PointF(axis.X -10, axis.Y));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X -10, axis.Y));

            graphics.DrawLine(pen, new PointF(axis.X - 5, axis.Y -10), new PointF(axis.X -10,axis.Y -10));
            graphics.DrawLine(pen, new PointF(axis.X -10, axis.Y), new PointF(axis.X - 15, axis.Y));
            graphics.DrawLine(pen, new PointF(axis.X -10, axis.Y -10), new PointF(axis.X - 15, axis.Y));
        }
    }
}
