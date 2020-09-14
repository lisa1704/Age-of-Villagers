using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class BangladeshiHouse : IHouse
    {
        public void drawHouse(Axes axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawLine(pen, new PointF(axes.X + 8, axes.Y - 8), new PointF(axes.X, axes.Y));
            elem.DrawLine(pen, new PointF(axes.X + 8, axes.Y - 8), new PointF(axes.X + 16, axes.Y));
            elem.DrawRectangle(pen, axes.X, axes.Y, 16, 8);
        }
    }
}
