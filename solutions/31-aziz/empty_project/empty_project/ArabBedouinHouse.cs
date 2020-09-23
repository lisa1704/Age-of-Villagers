using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class ArabBedouinHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 4, axis.Y + 10));
            graphics.DrawLine(pen, new PointF(axis.X - 4, axis.Y + 10), new PointF(axis.X + 4, axis.Y + 10));
            graphics.DrawLine(pen, new PointF(axis.X + 4, axis.Y + 10), new PointF(axis.X, axis.Y));

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X + 8,axis.Y - 6));
            graphics.DrawLine(pen, new PointF(axis.X + 8, axis.Y - 6), new PointF(axis.X + 12, axis.Y + 4));
            graphics.DrawLine(pen, new PointF(axis.X + 12, axis.Y + 4), new PointF(axis.X + 4, axis.Y + 10));
        }
    }
}
