using AgeOfVillagers.Data_Objects;
using System;
using System.Drawing;

namespace AgeOfVillagers.WaterResource
{
    public class EgyptianWaterSource : IWaterResource
    {
        public void Draw(ElementSize sz, Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawArc(pen, p.X, p.Y, sz.width, sz.height, 0, 360);
        }
    }
}
