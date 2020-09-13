using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Egyptian_Kings : INation
    {
        Pen p = new Pen(Color.Yellow);
        public void draw_house(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 40, 40);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 240, 240);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            
        }

        /*public string draw_house()
        {
            return "Egypt house";
        }

        public string draw_tree()
        {
            return "Egypt tree";
        }

        public string draw_waterSource()
        {
            return "Egypt watersource";
        }*/
    }
}
