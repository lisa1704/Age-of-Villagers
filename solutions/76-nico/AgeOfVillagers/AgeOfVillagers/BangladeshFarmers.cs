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
            Rectangle rec = new Rectangle(new Point(pt.X, pt.Y), new Point(pt.X + 15, pt.Y + 25));
            rec.Draw(g);
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
