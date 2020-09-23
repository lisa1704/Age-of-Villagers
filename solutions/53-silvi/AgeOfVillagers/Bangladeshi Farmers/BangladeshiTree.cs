using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers.BangladeshiFarmers
{
    class BangladeshiTree : Composite
    {
        public BangladeshiTree(Point point)
        {
            Point TopPoint = new Point(point.X + 16, point.Y + 16);
            Point TopLeft = new Point(point.X + 6, point.Y + 8);
            Point BottomRight = new Point(point.X + 10, point.Y + 24);


            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Ellipse(point, TopPoint));
        }
    }
    
}