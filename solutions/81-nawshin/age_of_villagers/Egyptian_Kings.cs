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
        public void draw_house(Graphics g, Point pt)
        {
            EgyptHouse house = new EgyptHouse(pt);
            house.draw(g);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            EgyptTree tree = new EgyptTree(pt);
            tree.draw(g);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            EgyptWatersource water = new EgyptWatersource(pt);
            water.draw(g);
        }
        public Color BackColor()
        {
            return Color.GreenYellow;
        }
    }
}
