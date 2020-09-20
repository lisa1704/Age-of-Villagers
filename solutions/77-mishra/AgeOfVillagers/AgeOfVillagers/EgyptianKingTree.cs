using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingTree : IShape
    {
        
        public EgyptianKingTree(Point p)
        {
           
        }

        public void draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color.GreenYellow);

            g.DrawLine(pen, p.X, p.Y, p.X + 12, p.Y - 16);
            g.DrawLine(pen, p.X, p.Y, p.X - 12, p.Y - 16);
            g.DrawLine(pen, p.X - 6, p.Y - 8, p.X - 6, p.Y - 16);
            g.DrawLine(pen, p.X - 6, p.Y - 8, p.X - 12, p.Y - 7);
            g.DrawLine(pen, p.X + 6, p.Y - 8, p.X + 12, p.Y - 7);
            g.DrawLine(pen, p.X + 6, p.Y - 8, p.X + 6, p.Y - 16);
        }
    }
}
