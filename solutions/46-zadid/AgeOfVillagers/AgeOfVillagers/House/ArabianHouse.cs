using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class ArabianHouse : IHouse
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X, p.Y, p.X + (sz.width - 5), p.Y);
            g.DrawLine(pen, p.X + (sz.width - 5), p.Y, p.X + (sz.width - 10), p.Y - (sz.height - 6));
            g.DrawLine(pen, p.X + (sz.width - 10), p.Y - (sz.height - 6), p.X, p.Y);
            g.DrawLine(pen, p.X + (sz.width - 10), p.Y - (sz.height - 6),p.X+(sz.width-6),p.Y-sz.height);
            g.DrawLine(pen, p.X + (sz.width - 6), p.Y - sz.height, p.X + sz.width, p.Y - (sz.height - 11));
            g.DrawLine(pen, p.X + sz.width, p.Y - (sz.height - 11), p.X + (sz.width - 5), p.Y);
        }
    }
}
