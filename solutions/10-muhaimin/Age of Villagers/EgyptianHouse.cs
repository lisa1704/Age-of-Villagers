using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class EgyptianHouse : IHouse
    {
        public void drawHouse(Axis axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X + 8, axes.Y + 12));
            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 8, axes.Y + 9));

            elem.DrawLine(pen, new PointF(axes.X + 8, axes.Y + 12), new PointF(axes.X - 2, axes.Y + 16));
            elem.DrawLine(pen, new PointF(axes.X - 8, axes.Y + 9), new PointF(axes.X - 2, axes.Y + 16));

            elem.DrawLine(pen, new PointF(axes.X, axes.Y), new PointF(axes.X - 2, axes.Y + 16));
        }
    }
}
