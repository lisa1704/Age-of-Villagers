using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class BangladeshiHouse : IHouse
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X, p.Y, p.X + sz.width, p.Y);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y + (sz.height-6));
            g.DrawLine(pen, p.X + sz.width, p.Y,p.X+sz.width,p.Y+(sz.height-6));
            g.DrawLine(pen, p.X, p.Y + (sz.height - 6), p.X + sz.width, p.Y + (sz.height - 6));
            g.DrawLine(pen, p.X, p.Y, p.X + (sz.width / 2),p.Y-6);
            g.DrawLine(pen, p.X + (sz.width / 2), p.Y - 6, p.X + sz.width, p.Y);
        }
    }
}
