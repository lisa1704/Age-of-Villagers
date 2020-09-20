using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi : INation
    {        
        public IObject Draw_house(Point lptop)
        {
            Compositeobj house = new Bangladeshi_house(lptop);
            return house;
        }
        public IObject Draw_tree(Point mptop)
        {
            Compositeobj tree = new Bangladeshi_tree(mptop);
            return tree;
        }
        public IObject Draw_watersource(Point p1)
        {
            Compositeobj watersource = new Bangladeshi_watersource(p1);
            return watersource;
        }

        public Color get_backcolor()
        {
            return Color.LightGreen;
        }
    }
}