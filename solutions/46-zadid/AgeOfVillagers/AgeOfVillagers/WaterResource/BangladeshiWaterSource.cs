using AgeOfVillagers.Data_Objects;
using System;
using System.Drawing;

namespace AgeOfVillagers.WaterResource
{
    public class BangladeshiWaterSource : IWaterResource
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, p.X, p.Y, p.X +3, p.Y - 3);
            g.DrawLine(pen, p.X + 3, p.Y - 3, p.X + 8, p.Y + 2);
            g.DrawLine(pen, p.X + 8, p.Y + 2, p.X + 4, p.Y-7);
            g.DrawLine(pen, p.X + 4, p.Y - 7, p.X -  5, p.Y - 6);
            g.DrawLine(pen, p.X - 5, p.Y - 6, p.X, p.Y);
        }
    }
}
