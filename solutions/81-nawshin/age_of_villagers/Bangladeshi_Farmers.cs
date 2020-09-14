using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class Bangladeshi_Farmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void draw_house(Graphics g,Point pt)
        {
            //g.DrawLine(p, pt.X, pt.Y, 20, 20);

            BDHouse house = new BDHouse(pt);
            house.draw(g);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 20, 20);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 20, 20);
        }

        /*public string draw_house()
        {
            return "Bangladesh house";
        }
        public string draw_tree()
        {
            return "Bangladesh tree";
        }

        public string draw_waterSource()
        {
            return "Bangladesh watersource";
        }*/
    }
}
