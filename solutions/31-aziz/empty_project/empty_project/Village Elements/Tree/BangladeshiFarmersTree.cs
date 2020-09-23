using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class BangladeshiFarmersTree : ITree
    {
        public void drawTree(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            float startAngle = 0.0F;
            float sweepAngle = 360.0F;

            graphics.DrawArc(pen, axis.X, axis.Y, 12, 16, startAngle, sweepAngle);

            graphics.DrawLine(pen, new PointF(axis.X + 5, axis.Y + 11), new PointF(axis.X + 7, axis.Y + 11));
            graphics.DrawLine(pen, new PointF(axis.X + 7, axis.Y + 11), new PointF(axis.X + 7, axis.Y + 23));
            graphics.DrawLine(pen, new PointF(axis.X + 7, axis.Y + 23), new PointF(axis.X + 5, axis.Y + 23));
            graphics.DrawLine(pen, new PointF(axis.X + 5, axis.Y + 23), new PointF(axis.X + 5, axis.Y + 11));
        }
    }
}
