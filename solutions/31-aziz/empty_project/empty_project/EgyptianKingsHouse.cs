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

            graphics.DrawLine(pen, new PointF(axis.X,axis.Y), new PointF(axis.X + 20, axis.Y + 30));
            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 20, axis.Y + 22));

            graphics.DrawLine(pen, new PointF(axis.X + 20, axis.Y + 30), new PointF(axis.X - 8, axis.Y + 40));
            graphics.DrawLine(pen, new PointF(axis.X - 20, axis.Y + 22), new PointF(axis.X - 8, axis.Y + 40));

            graphics.DrawLine(pen, new PointF(axis.X, axis.Y), new PointF(axis.X - 8, axis.Y + 40));
        }
    }
}
