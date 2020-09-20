using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi : INation
    {
        Size housesize=new Housesize();
        Size treesize = new Treesize();
        Size watersourcesize = new BDWatersourcesize();

        public IObject Draw_house(Point lptop)
        {
            int height = housesize.GetHeight();
            int weidth = housesize.GetWeidth();
            Compositeobj house = new Bangladeshi_house(lptop,height,weidth);
            return house;
        }

        public IObject Draw_tree(Point mptop)
        {
            int height = treesize.GetHeight();
            int weidth = treesize.GetWeidth();
            Compositeobj tree = new Bangladeshi_tree(mptop, height, weidth);
            return tree;
        }

        public IObject Draw_watersource(Point p1)
        {
            int height = watersourcesize.GetHeight();
            int weidth = watersourcesize.GetWeidth();
            Compositeobj watersource = new Bangladeshi_watersource(p1, height, weidth);
            return watersource;
        }


        public Color get_backcolor()
        {
            return Color.LightGreen;
        }
    }
}