using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BaseArc : IGraphicShape
    {
        private Point  _point;
        private int _h, _w,_initial,_angle;
        public BaseArc(Point point, int h, int w,int initial,int angle)
        {
            _point = point;
            _h = h;
            _w = w;
            _initial = initial;
            _angle = angle;


        }
        public void draw(Graphics g, Pen pen)
        {
            Rectangle shape = new Rectangle(_point.X, _point.Y, _h, _w);
            Rectangle shape_1 = new Rectangle(_point.X+10, _point.Y+10, _h-20, _w-20);
            g.DrawArc(pen, shape, _initial, _angle);
            g.DrawArc(pen, shape_1, _initial, _angle);
        }
    }
}
