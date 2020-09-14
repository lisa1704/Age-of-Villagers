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
            EgyptHouse house = new EgyptHouse(pt);
            house.draw(g);
        }

        public void draw_tree(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 240, 240);
        }

        public void draw_watersource(Graphics g, Point pt)
        {
            EgyptWatersource water = new EgyptWatersource(pt);
            water.draw(g);
        }

    }
}
