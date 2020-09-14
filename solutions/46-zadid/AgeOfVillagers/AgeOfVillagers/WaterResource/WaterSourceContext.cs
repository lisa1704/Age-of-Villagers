using AgeOfVillagers.Data_Objects;
using AgeOfVillagers.WaterResource;
using System.Drawing;

namespace AgeOfVillagers.WaterResource
{
    public class WaterSourceContext
    {
        public IWaterResource _watersourcetype;
        public Graphics _g;
        public Point _p;
        public ElementSize _sz;

        public WaterSourceContext(IWaterResource house, Graphics g, Point p, ElementSize sz)
        {
            this._watersourcetype = house;
            this._g = g;
            this._p = p;
            this._sz = sz;
        }

        public void WaterSourceDrawing()
        {
            _watersourcetype.Draw(_sz, _g, _p);
        }
    }
}
