using AgeOfVillagers.Data_Objects;
using System.Drawing;
using AgeOfVillagers.Components;

namespace AgeOfVillagers.Tree
{
    public class ArabianTree : CompositeShape
    {
        /*public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            //g.DrawLine(pen, p.X - 2, p.Y, p.X + 2, p.Y);
            //g.DrawLine(pen, p.X - 2, p.Y, p.X - 2, p.Y + sz.height / 2);
            //g.DrawLine(pen, p.X + 2, p.Y, p.X + 2, p.Y + sz.height / 2);
            //g.DrawLine(pen, p.X - 2, p.Y + sz.height / 2, p.X + 2, p.Y + sz.height / 2);
            g.DrawLine(pen, p.X, p.Y, p.X - sz.width / 2, p.Y - sz.height/4);
            g.DrawLine(pen, p.X, p.Y, p.X - sz.width / 2, p.Y - sz.height/2);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y - sz.height / 2);
            g.DrawLine(pen, p.X, p.Y, p.X + sz.width / 2, p.Y - sz.height / 4);
            g.DrawLine(pen, p.X, p.Y, p.X + sz.width / 2, p.Y - sz.height / 2);
        }*/

        public ArabianTree(Point p, ElementSize sz)
        {
            Point mid = p;
            Point l1 = new Point(p.X - sz.width / 2, p.Y - sz.height / 4);
            Point l2 = new Point(p.X - sz.width / 2, p.Y - sz.height / 2);
            Point l3 = new Point(p.X, p.Y - sz.height / 2);
            Point l4 = new Point(p.X + sz.width / 2, p.Y - sz.height / 4);
            Point l5 = new Point(p.X + sz.width / 2, p.Y - sz.height / 2);
            Point topleft = new Point(p.X - 2, p.Y);
            Point topright = new Point(p.X + 2, p.Y);
            Point bottomleft = new Point(p.X - 2, p.Y + sz.height / 2);
            Point bottomRight = new Point(p.X + 2, p.Y + sz.height / 2);

            AddComponent(new Components.Rectangle(topleft, topright, bottomleft, bottomRight));
            AddComponent(new Line(mid.X,mid.Y, l1.X,l1.Y));
            AddComponent(new Line(mid.X, mid.Y, l2.X, l2.Y));
            AddComponent(new Line(mid.X, mid.Y, l3.X, l3.Y));
            AddComponent(new Line(mid.X, mid.Y, l4.X, l4.Y));
            AddComponent(new Line(mid.X, mid.Y, l5.X, l5.Y));
            
        }

    }
}
