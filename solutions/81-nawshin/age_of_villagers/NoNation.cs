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
            //do nothing
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
            return Color.White;
        }
    }
}
