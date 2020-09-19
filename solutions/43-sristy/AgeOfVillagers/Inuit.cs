using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Inuit : INation
    {
        public IObject Draw_house(Point mptop)
        {
            IObject house = new Inuit_house(mptop);
            return house;

        }

        public IObject Draw_tree(Point mptop)
        {
            IObject tree = new null_obj();
            return tree;

        }

        public IObject Draw_watersource(Point mptop)
        {
            IObject waterresource = new null_obj();
            return waterresource;
        }

        public Color get_backcolor()
        {
            return Color.Snow;
        }
    }
}
