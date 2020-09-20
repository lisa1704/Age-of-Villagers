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
        public void draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color.Blue);
            g.DrawArc(pen, p.X, p.Y, 12, 12, 45, 360);
        }
    }
}
