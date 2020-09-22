﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class EgyptKingsWaterSource : IWaterSource
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public EgyptKingsWaterSource(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(mypen, x, y, 12, 12, 0, 360);
        }
    }
}
