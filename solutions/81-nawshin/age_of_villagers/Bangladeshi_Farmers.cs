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
        public void draw_house(Graphics g,Point pt)
        {
            BDHouse house = new BDHouse(pt);
            house.draw(g);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            BDTree tree = new BDTree(pt);
            tree.draw(g);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            BDWatersource water = new BDWatersource(pt);
            water.draw(g);
        }
        public Color BackColor()
        {
            Color color = Color.LightGreen;
            return color;
        }
    }
}
