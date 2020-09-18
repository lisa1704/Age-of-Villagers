using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class BangladeshiTree : ITree
    {
        public void drawTree(Axes axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawEllipse(pen, axes.X, axes.Y, 16, 16);
            elem.DrawEllipse(pen, axes.X + 7, axes.Y + 16, 2, 8);
        }
    }
}
