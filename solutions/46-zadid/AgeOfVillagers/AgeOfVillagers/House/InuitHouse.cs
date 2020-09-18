using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class InuitHouse : IHouse
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X,p.Y+sz.width/2,p.X+sz.width,p.Y+sz.width/2);
            g.DrawArc(pen, p.X, p.Y, sz.width, sz.height, 0, -180);
            g.DrawArc(pen,p.X + sz.height / 3, p.Y + sz.height / 2 - sz.height / 8, sz.height / 4, sz.height / 4, 0, -180);
        }
    }
}
