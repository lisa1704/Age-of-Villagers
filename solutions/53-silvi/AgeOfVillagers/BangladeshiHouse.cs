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
    class BangladeshiHouse : Composite
    {
        public BangladeshiHouse(Point point)
        {
            Point TopLeft = new Point(point.X - 8, point.Y + 8);
            Point BottomRight = new Point(point.X + 8, point.Y + 16);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);

            AddComponent(new System.Drawing.Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(point, TopLeft, TopRight));
        }

        
    }
}