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
        

        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.Brown);

            graphics.DrawLine(pen, p.X, p.Y, p.X + 8, p.Y);
            graphics.DrawLine(pen, p.X, p.Y, p.X + 4, p.Y - 16);
            graphics.DrawLine(pen, p.X + 4, p.Y - 16, p.X + 8, p.Y);
            graphics.DrawLine(pen, p.X + 8, p.Y, p.X + 16, p.Y - 8);
            graphics.DrawLine(pen, p.X + 4, p.Y - 16, p.X + 16, p.Y - 8);
        }
    }
}
