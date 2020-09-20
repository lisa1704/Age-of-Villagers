using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabHouse : IShape
    {
        
        public ArabHouse(Point p)
        {
            
        }

        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.Brown);
            graphics.DrawLine(pen, p.X, p.Y + 16, p.X + 4, p.Y + 16);
            graphics.DrawLine(pen, p.X, p.Y + 16, p.X + 2, p.Y + 12);
            graphics.DrawLine(pen, p.X + 2, p.Y + 12, p.X + 4, p.Y + 16);
            graphics.DrawLine(pen, p.X + 2, p.Y + 12, p.X + 12, p.Y);
            graphics.DrawLine(pen, p.X + 12, p.Y, p.X + 16, p.Y + 11);
            graphics.DrawLine(pen, p.X + 16, p.Y + 11, p.X + 4, p.Y + 16);
        }
    }
}
