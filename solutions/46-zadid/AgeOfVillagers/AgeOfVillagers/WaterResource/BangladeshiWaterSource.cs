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

            g.DrawLine(pen, p.X, p.Y, p.X + sz.width / 3, p.Y - sz.height / 3);
            g.DrawLine(pen, p.X + sz.width / 3, p.Y - sz.height / 3, p.X + sz.width / 8, p.Y + sz.height + 2);
            g.DrawLine(pen, p.X + sz.width / 8, p.Y + sz.height + 2, p.X + sz.width / 4, sz.height / 7);
            g.DrawLine(pen, p.X + sz.width / 4, sz.height / 7, p.X - sz.width / 5, p.Y - sz.height / 6);
            g.DrawLine(pen, p.X - sz.width / 5, p.Y - sz.height / 6, p.X, p.Y);
        }
    }
}
