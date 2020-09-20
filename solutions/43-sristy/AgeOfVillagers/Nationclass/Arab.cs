using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Arab : INation
    {
        Size housesize = new Housesize();
        Size treesize = new Treesize();
        public IObject Draw_house(Point lptop)
        {
            int height = housesize.GetHeight();
            int weidth = housesize.GetWeidth();
            IObject house = new Arab_house(lptop, height, weidth);
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