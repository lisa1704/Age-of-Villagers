using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianWatersrc : IWatersrc
    {
        public void drawWatersrc(Point p, Panel panel)
        {
            Pen pen = new Pen(Color.Black);
            Graphics g = panel.CreateGraphics();
            g.DrawArc(pen, p.X, p.Y, 12, 12, 0, 360);
        }
    }
}
