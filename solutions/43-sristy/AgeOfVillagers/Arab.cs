using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Arab : INation
    {
        Pen p = new Pen(Color.Gold);
        public void Draw_house(Graphics g, Point lptop)
        {
            Compositeobj house = new Arab_house(lptop);
            house.paint(p, g);
        }

        public void Draw_tree(Graphics g, Point mptop)
        {
            Compositeobj tree = new Arab_tree(mptop);
            tree.paint(p, g);
        }

        public void Draw_watersource(Graphics g, Point P1)
        {
            IObject waterresource = new null_obj();
            waterresource.paint(p, g);
        }

        public Color get_backcolor()
        {
            return Color.PaleGoldenrod;
        }
    }
}