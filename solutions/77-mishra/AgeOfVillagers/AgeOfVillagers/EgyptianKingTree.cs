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

        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.GreenYellow);

            graphics.DrawLine(pen, p.X, p.Y, p.X + 12, p.Y - 16);
            graphics.DrawLine(pen, p.X, p.Y, p.X - 12, p.Y - 16);
            graphics.DrawLine(pen, p.X - 6, p.Y - 8, p.X - 6, p.Y - 16);
            graphics.DrawLine(pen, p.X - 6, p.Y - 8, p.X - 12, p.Y - 7);
            graphics.DrawLine(pen, p.X + 6, p.Y - 8, p.X + 12, p.Y - 7);
            graphics.DrawLine(pen, p.X + 6, p.Y - 8, p.X + 6, p.Y - 16);
        }
    }
}
