using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class ArabHouse : IHouse
    {
        public void drawHouse(Axis axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            //draw triangle
            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 5, axes.Y - 10));
            elem.DrawLine(pen, new PointF(axes.X - 5, axes.Y - 10), new PointF(axes.X - 10, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 10, axes.Y));

            //draw square
            elem.DrawLine(pen, new PointF(axes.X - 5, axes.Y - 10), new PointF(axes.X - 10, axes.Y - 10));
            elem.DrawLine(pen, new PointF(axes.X - 10, axes.Y), new PointF(axes.X - 15, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X - 10, axes.Y - 10), new PointF(axes.X - 15, axes.Y));
        }
    }
}
