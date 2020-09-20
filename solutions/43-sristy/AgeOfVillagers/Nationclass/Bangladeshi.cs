using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi : INation
    {
        Size housesize=new Housesize();
        Size treesize = new Treesize();

        public IObject Draw_house(Point lptop)
        {
            int height = housesize.GetHeight();
            int weight = housesize.GetWeidth();
            Compositeobj house = new Bangladeshi_house(lptop,height,weight);
            return house;
        }

        public IObject Draw_tree(Point mptop)
        {
            int height = treesize.GetHeight();
            int weight = treesize.GetWeidth();
            Compositeobj tree = new Bangladeshi_tree(mptop, height, weight);
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