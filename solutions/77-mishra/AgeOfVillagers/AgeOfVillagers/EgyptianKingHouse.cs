using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKingHouse : CompositeShapes
    {
        private Point point;
        public EgyptianKingHouse(Point point)
        {
            Point p1 = point;
            Point bottomleft = new Point(p1.X - 8, p1.Y + 16);
            Point bottomright = new Point(p1.X + 8, p1.Y + 16);
            Point corner = new Point(p1.X + 16, p1.Y + 8 );

            addshapes(new Triangle(p1, bottomright, bottomleft));
            addshapes(new Triangle(p1, bottomright, corner));

        }
        

        
    }
}
