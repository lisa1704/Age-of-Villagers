using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.NationItems
{
    class InuitItems : INationItems
    {
        Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
        Pen pen = new Pen(Color.Black);
        public void House(Graphics g, Point p)
        {
            // draw igloo
            Circle c = new Circle(g,p,16);
        }

        public void Tree(Graphics g, Point p)
        {

        }

        public void Water(Graphics g, Point p)
        {
           
        }
    }
}
