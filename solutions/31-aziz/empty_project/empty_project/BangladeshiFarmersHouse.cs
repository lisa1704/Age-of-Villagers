using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace empty_project
{
    public class BangladeshiFarmersHouse : IHouse
    {
        public void drawHouse(Axis axis, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graphics = panel.CreateGraphics();

            graphics.DrawLine(pen, new PointF(axis.X + 20, axis.Y - 20), new PointF(axis.X, axis.Y));
            graphics.DrawLine(pen, new PointF(axis.X + 20, axis.Y - 20), new PointF(axis.X + 40, axis.Y));
            graphics.DrawRectangle(pen, axis.X, axis.Y, 40, 20);
        }
    }
}
