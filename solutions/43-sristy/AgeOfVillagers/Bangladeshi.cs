using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi : INation
    {
        Pen p = new Pen(Color.Green);
        
        public void Draw_house(Graphics g,Point lptop)
        {
            Compositeobj house = new Bangladeshi_house(lptop);
            house.paint(p,g);
        }
        public void Draw_tree(Graphics g,Point mptop)
        {
            Compositeobj tree = new Bangladeshi_tree(mptop);
            tree.paint(p, g);
        }
        public void Draw_watersource(Graphics g,Point p1)
        {
            Compositeobj watersource = new Bangladeshi_watersource(p1);
            watersource.paint(p, g);

        }

        public Color get_backcolor()
        {
            return Color.LightGreen;
        }
    }
}