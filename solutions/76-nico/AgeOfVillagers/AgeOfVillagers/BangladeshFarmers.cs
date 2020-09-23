using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class BangladeshFarmers : INation
    {
        Pen p = new Pen(Color.Pink);
        public void draw_house(Graphics g, Point pt)
        {
            throw new NotImplementedException();
            g.DrawLine(p, pt.X, pt.Y, 100, 100);
           BD_House bdhouse = new BD_House(new Point(pt.X, pt.Y), new Point(pt.X - 50, pt.Y * 10), new Point(pt.X + 100, pt.Y * 10));
        }

        public void draw_house()
        {
            throw new NotImplementedException();
        }

        public void draw_tree()
        {
            throw new NotImplementedException();
        }
        
        public void draw_watersource()
        {
            throw new NotImplementedException();
        }


    }
}
