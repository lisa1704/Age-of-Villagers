using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Arab : INation
    {
        public IObject Draw_house(Point lptop)
        {
            IObject house = new Arab_house(lptop);
            return house;
        }

        public IObject Draw_tree(Point mptop)
        {
            IObject tree = new Arab_tree(mptop);
            return tree;
        }

        public IObject Draw_watersource(Point P1)
        {
            IObject waterresource = new null_obj();
            return waterresource;
        }

        public Color get_backcolor()
        {
            return Color.PaleGoldenrod;
        }
    }
}