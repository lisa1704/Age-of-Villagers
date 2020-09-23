using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers.NationItems
{
    class BDItems : INationItem
    {
        public void House(Graphics g, Point p)
        {
           /* Triangle t = new Triangle(g, p1,p2,);
            Rectangle r = new Rectangle(g, p);
            t.Draw();
            r.Draw();
           */
        }

        public void Tree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void Water(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
    }
}
