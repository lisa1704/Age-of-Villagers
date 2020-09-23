using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Inuit_Hunters : INation
    {
        public void draw_house()
        {
            throw new NotImplementedException();
        }
        Pen p = new Pen(Color.Yellow);

        public void draw_house(Graphics g, Point pt)
        {
            throw new NotImplementedException();
            g.DrawLine(p, pt.X, pt.Y, 100, 100);

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
