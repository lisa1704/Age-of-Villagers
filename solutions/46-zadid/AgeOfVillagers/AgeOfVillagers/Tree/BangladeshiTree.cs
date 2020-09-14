using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.Tree
{
    public class BangladeshiTree : ITree
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen,p.X, p.Y, p.X + 2, p.Y);
            g.DrawLine(pen,p.X + 2, p.Y, p.X + 2, p.Y + sz.height / 2);
            g.DrawLine(pen, p.X + 2, p.Y + sz.height / 2, p.X, p.Y + sz.height / 2);
            g.DrawLine(pen,p.X, p.Y + sz.height / 2, p.X, p.Y);
            g.DrawArc(pen, p.X-sz.width/3, p.Y-sz.height/2, sz.height / 2, sz.width, 0, 360);

        }
    }
}
