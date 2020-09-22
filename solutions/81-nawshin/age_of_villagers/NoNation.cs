using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    public class NoNation : INation
    {
        public void draw_house(Graphics g, Point pt)
        {
            NullShape house = new NullShape(pt);
            house.draw(g);
        }
        public void draw_tree(Graphics g, Point pt)
        {
            NullShape tree = new NullShape(pt);
            tree.draw(g);
        }
        public void draw_watersource(Graphics g, Point pt)
        {
            NullShape water = new NullShape(pt);
            water.draw(g);
        }
        public Color BackColor()
        {
            return Color.Empty;
        }
    }
}
