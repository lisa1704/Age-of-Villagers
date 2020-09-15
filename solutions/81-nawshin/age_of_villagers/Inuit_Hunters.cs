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
            InuitHouse house = new InuitHouse(pt);
            house.draw(g);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            //do nothing
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            //do nothing
        }
        public Color BackColor()
        {
            return Color.Snow;
        }

    }
}
