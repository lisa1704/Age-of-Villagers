using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawVillage
{
    class Draw
    {
        private void splitter1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Blue);

            g.DrawRectangle(myPen, 2, 2, 100, 200);
        }
    }
}
