using AgeOfVillagers.Data_Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.House
{
    class HouseContext
    {
        public IHouse _housetype;
        public Graphics _g;
        public Point _p;
        public ElementSize _sz;

        public HouseContext(IHouse house, Graphics g, Point p, ElementSize sz)
        {
            this._housetype = house;
            this._g = g;
            this._p = p;
            this._sz = sz;
        }

        public void HouseDrawing()
        {
            _housetype.Draw(_sz, _g, _p);
        }
    }
}
