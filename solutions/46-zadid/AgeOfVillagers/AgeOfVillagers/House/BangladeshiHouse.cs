using AgeOfVillagers.Data_Objects;
using System.Drawing;

namespace AgeOfVillagers.House
{
    public class BangladeshiHouse : IHouse
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, p.X, p.Y, sz.width, sz.height);
        }
    }
}
