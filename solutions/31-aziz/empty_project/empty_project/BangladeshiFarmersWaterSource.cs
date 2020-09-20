using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class BangladeshiFarmersWaterSource : IWaterSource
    {
        public void drawWaterSource(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X + 15, axis.Y + 15));
            graphics.DrawLine(pen, new PointF(axis.X + 15, axis.Y + 15), new PointF(axis.X + 25, axis.Y + 10));
            graphics.DrawLine(pen, new PointF(axis.X + 25, axis.Y + 10), new PointF(axis.X + 35, axis.Y + 15));
            graphics.DrawLine(pen, new PointF(axis.X + 35, axis.Y + 15), new PointF(axis.X + 50, axis.Y));
            graphics.DrawLine(pen, new PointF(axis.X +50, axis.Y), new PointF(axis.X + 45, axis.Y -25));
            graphics.DrawLine(pen, new PointF(axis.X + 45, axis.Y - 25), new PointF(axis.X + 25, axis.Y - 20));
            graphics.DrawLine(pen, new PointF(axis.X + 25, axis.Y - 20), new PointF(axis.X + 20, axis.Y - 30));
            graphics.DrawLine(pen, new PointF(axis.X + 20, axis.Y - 30), new PointF(axis.X + 10, axis.Y -20));
            graphics.DrawLine(pen, new PointF(axis.X + 10, axis.Y - 20), new PointF(axis.X, axis.Y));
        }
    }
}
