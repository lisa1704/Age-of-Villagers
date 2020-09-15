using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Inuit : INation
    {
        Pen p = new Pen(Color.Black);
        public void Draw_house(Graphics g,Point mptop)
        {
            Compositeobj house = new Inuit_house(mptop);
            house.paint(p, g);

        }

        public void Draw_tree(Graphics g,Point mptop)
        {
            IObject tree = new null_obj();
            tree.paint(p, g);

        }

        public void Draw_watersource(Graphics g,Point mptop)
        {
            IObject waterresource = new null_obj();
            waterresource.paint(p, g);
        }

        public Color get_backcolor()
        {
            return Color.Snow;
        }
    }
}
