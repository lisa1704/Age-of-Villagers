using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
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
