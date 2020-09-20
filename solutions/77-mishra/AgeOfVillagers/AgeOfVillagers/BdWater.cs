using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BdWater : IShape
    {

        public BdWater(Point p)
        {
            
        }
       

        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.Blue);

            graphics.DrawLine(pen, p.X, p.Y, p.X + 3, p.Y + 6);
            graphics.DrawLine(pen, p.X, p.Y, p.X + 5, p.Y - 5);
            graphics.DrawLine(pen, p.X + 3, p.Y + 6, p.X + 8, p.Y + 1);
            graphics.DrawLine(pen, p.X + 8, p.Y + 1, p.X + 16, p.Y + 8);
            graphics.DrawLine(pen, p.X + 16, p.Y + 8, p.X + 24, p.Y - 2);
            graphics.DrawLine(pen, p.X + 24, p.Y - 2, p.X + 15, p.Y - 8);
            graphics.DrawLine(pen, p.X + 15, p.Y - 8, p.X + 7, p.Y - 4);
            graphics.DrawLine(pen, p.X + 7, p.Y - 4, p.X + 7, p.Y - 6);
            graphics.DrawLine(pen, p.X + 7, p.Y - 6, p.X + 5, p.Y - 5);
        }
    }
}
