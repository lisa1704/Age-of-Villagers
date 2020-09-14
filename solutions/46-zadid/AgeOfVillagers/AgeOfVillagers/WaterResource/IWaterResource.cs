using AgeOfVillagers.Data_Objects;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.WaterResource
{
    public interface IWaterResource
    {
        public void Draw(ElementSize sz, Graphics g, Point p);
    }
}
