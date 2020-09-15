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
            ArabHouse house = new ArabHouse(pt);
            house.draw(g);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            ArabTree tree = new ArabTree(pt);
            tree.draw(g);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            //do nothing
        } 
    }
}
