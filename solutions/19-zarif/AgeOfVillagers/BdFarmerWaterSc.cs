using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BdFarmerWaterSc : CompositeShape
    {
        Point _point;
        public BdFarmerWaterSc(Point point)
        {

            _point = point;
            Point sec_point = new Point(_point.X + 8, _point.Y - 8);
            Point th_point = new Point(sec_point.X+10 , sec_point.Y + 8);
            Point fou_point = new Point(th_point.X + 8, _point.Y - 12);

            Point fift_point = new Point(fou_point.X + 8, _point.Y+5);

            Point six_point = new Point(fift_point.X + 8, _point.Y - 8);

            Point sev_point = new Point(six_point.X , six_point.Y + 16);
            Point eig_point = new Point(sev_point.X-8 , sev_point.Y + 8);
            Point nin_point = new Point(eig_point.X - 8, sev_point.Y + 8);
            Point ten_point = new Point(nin_point.X - 10, sev_point.Y + 8);

            addShape(new BaseLine(_point,sec_point));
            addShape(new BaseLine(sec_point,th_point));
            addShape(new BaseLine( th_point,fou_point));
            addShape(new BaseLine(fou_point, fift_point));
            addShape(new BaseLine(fift_point, six_point));
            addShape(new BaseLine(six_point, sev_point));
            addShape(new BaseLine(sev_point, eig_point));
            addShape(new BaseLine(eig_point, nin_point));
            addShape(new BaseLine(nin_point,ten_point));
            addShape(new BaseLine(ten_point, _point));


        }

        
    }
}
