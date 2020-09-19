using AgeOfVillagers.Components;
using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class EgyptianHouse : CompositeShape
    {
        /*public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X, p.Y, p.X - sz.width / 2, p.Y - sz.height / 4);
            g.DrawLine(pen, p.X, p.Y, p.X + sz.width / 2, p.Y - sz.height / 3);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y - sz.height);
            g.DrawLine(pen, p.X, p.Y - sz.height, p.X - sz.width / 2, p.Y - sz.height / 4);
            g.DrawLine(pen, p.X, p.Y - sz.height, p.X + sz.width / 2, p.Y - sz.height / 3);
        }*/

        public EgyptianHouse(Point p, ElementSize sz)
        {
            Point top = p;
            Point bottomMid = new Point(p.X + sz.width / 4, p.Y + sz.height);
            Point bottomleft = new Point(bottomMid.X - sz.width * 10 / 16, p.Y + sz.height - sz.height / 4);
            Point bottomRight = new Point(bottomMid.X + sz.width * 6 / 16, p.Y + (sz.height / 2));



            AddComponent(new Triangle(top, bottomMid, bottomleft));
            AddComponent(new Triangle(top, bottomMid, bottomRight));



        }
    }
}
