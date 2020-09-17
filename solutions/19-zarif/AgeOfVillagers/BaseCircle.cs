using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BaseCircle : IGraphicShape
    {

        private readonly Point _point ;
        private int _h,_w;

        public BaseCircle(Point point,int h,int w)
        {
            _point = point;
            _h = h;
            _w = w;
        }
        public void draw(Graphics g, Pen pen)
        {
            Rectangle shape = new Rectangle(_point.X,_point.Y,_h,_w);
            g.DrawEllipse(pen, shape);
        }
    }
}
