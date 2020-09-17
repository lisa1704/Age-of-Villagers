using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BaseCircle : IGraphicShape
    {

        private readonly Point _point ;
        private int _radius;

        public BaseCircle(Point point,int radius)
        {
            _point = point;
        }
        public void draw(Graphics g, Pen pen)
        {
           
        }
    }
}
