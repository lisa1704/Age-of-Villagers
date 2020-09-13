using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Inuit_Hunters : INation
    {
        Pen p = new Pen(Color.White);
        public void draw_house(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 200, 200);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            
        }

        /*public string draw_house()
        {
            return "Inuit house";
        }
        public string draw_tree()
        {
            return "Inuit tree";
        }

        public string draw_waterSource()
        {
            return "Inuit watersource";
        }*/
    }
}
