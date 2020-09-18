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

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 3, axis.Y - 3));
            graphics.DrawLine(pen, new PointF(axis.X - 3, axis.Y - 3), new PointF(axis.X - 6, axis.Y + 5));
            graphics.DrawLine(pen, new PointF(axis.X - 6, axis.Y + 5), new PointF(axis.X - 12, axis.Y - 1));
            graphics.DrawLine(pen, new PointF(axis.X - 12, axis.Y - 1), new PointF(axis.X - 24, axis.Y + 6));
            graphics.DrawLine(pen, new PointF(axis.X - 24, axis.Y + 6), new PointF(axis.X - 13, axis.Y + 24));
            graphics.DrawLine(pen, new PointF(axis.X - 13, axis.Y + 24), new PointF(axis.X, axis.Y + 10));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y + 10), new PointF(axis.X, axis.Y));
        }
    }
}
