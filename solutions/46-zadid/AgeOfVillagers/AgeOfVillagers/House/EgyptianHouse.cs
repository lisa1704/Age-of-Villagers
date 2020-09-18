using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class EgyptianHouse : IHouse
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X, p.Y, p.X - sz.width / 2, p.Y - sz.height / 4);
            g.DrawLine(pen, p.X, p.Y, p.X + sz.width / 2, p.Y - sz.height / 3);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y - sz.height);
            g.DrawLine(pen, p.X, p.Y - sz.height, p.X - sz.width / 2, p.Y - sz.height / 4);
            g.DrawLine(pen, p.X, p.Y - sz.height, p.X + sz.width / 2, p.Y - sz.height / 3);
        }
    }
}
