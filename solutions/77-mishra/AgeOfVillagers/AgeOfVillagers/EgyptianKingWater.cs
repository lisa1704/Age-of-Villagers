using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingWater : IShape
    {
        
        public EgyptianKingWater(Point p)
        {
            
        }
        public void draw(Point p, Graphics graphics)
        {
            Pen pen = new Pen(Color.Blue);
            graphics.DrawArc(pen, p.X, p.Y, 12, 12, 45, 360);
        }
    }
}
