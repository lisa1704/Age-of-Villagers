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
        public void draw(Axis axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            //draw triangle
            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 4, axes.Y - 8));
            elem.DrawLine(pen, new PointF(axes.X - 4, axes.Y - 8), new PointF(axes.X - 8, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 8, axes.Y));

            //draw square
            elem.DrawLine(pen, new PointF(axes.X - 4, axes.Y - 8), new PointF(axes.X - 8, axes.Y - 8));
            elem.DrawLine(pen, new PointF(axes.X - 8, axes.Y), new PointF(axes.X - 12, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X - 8, axes.Y - 8), new PointF(axes.X - 12, axes.Y));
        }
    }
}
