using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingHouse : IShape
    {
        
        public EgyptianKingHouse(Point p)
        {
            
        }
        

        public void draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color.Brown);

            g.DrawLine(pen, p.X, p.Y, p.X + 8, p.Y);
            g.DrawLine(pen, p.X, p.Y, p.X + 4, p.Y - 16);
            g.DrawLine(pen, p.X + 4, p.Y - 16, p.X + 8, p.Y);
            g.DrawLine(pen, p.X + 8, p.Y, p.X + 16, p.Y - 8);
            g.DrawLine(pen, p.X + 4, p.Y - 16, p.X + 16, p.Y - 8);
        }
    }
}
