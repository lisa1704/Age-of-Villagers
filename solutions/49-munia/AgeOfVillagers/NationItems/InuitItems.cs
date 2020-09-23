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
        Point p1,p2,p3;
        Pen pen = new Pen(Color.Black);
        public void House(Graphics g, Point p)
        {
            // draw igloo
            p1.X = p.X + 16;
            p1.Y = p.Y + 8;
            p2.X = p.X + 6;
            p2.Y = p.Y + 6;
            p3.X = p.X;
            p3.Y = p.Y + 8;

            HalfCircle c = new HalfCircle(g, p, 16);
            HalfCircle c2 = new HalfCircle(g, p2, 4);
            c.Draw();
            c2.Draw();
            g.DrawLine(pen, p3, p1);

        }

        public void Tree(Graphics g, Point p)
        {

        }

        public void Water(Graphics g, Point p)
        {
           
        }
    }
}
