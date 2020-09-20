using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BdFarmerHouse : IShape
    {
        public BdFarmerHouse(Point p)
        {
          
        }
        public void draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color.Brown);

            g.DrawLine(pen, p.X, p.Y, p.X + 8, p.Y + 8);
            g.DrawLine(pen, p.X, p.Y, p.X - 8, p.Y + 8);
            g.DrawLine(pen, p.X - 8, p.Y + 8, p.X + 8, p.Y + 8);
            g.DrawLine(pen, p.X - 8, p.Y + 16, p.X - 8, p.Y + 8);
            g.DrawLine(pen, p.X + 8, p.Y + 8, p.X + 8, p.Y + 16);
            g.DrawLine(pen, p.X - 8, p.Y + 16, p.X + 8, p.Y + 16);
        }
    }
}
