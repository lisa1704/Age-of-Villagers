using AgeOfVillagers.Data_Objects;
using System;
using System.Drawing;
using AgeOfVillagers.Components;

namespace AgeOfVillagers.WaterResource
{
    public class EgyptianWaterSource : CompositeShape
    {
        public EgyptianWaterSource(Point p, ElementSize sz)
        {
            AddComponent(new Arc(p.X, p.Y, sz.width, sz.height, 0, 360));
        }
    }
}
