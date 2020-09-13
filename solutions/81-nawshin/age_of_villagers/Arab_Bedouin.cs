using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Arab_Bedouin : INation
    {
        Pen p = new Pen(Color.YellowGreen);
        public void draw_house(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 80, 80);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 800, 800);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 220, 220);
        }

        /*public string draw_house()
        {
            return "Arab house";
        }
        public string draw_tree()
        {
            return "Arab tree";
        }

        public string draw_waterSource()
        {
            return "Arab watersource";
        }*/
    }
}
