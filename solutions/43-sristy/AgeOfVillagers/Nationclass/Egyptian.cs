using System;
using System.Drawing;

namespace Age_of_villagers
{ 
    public class Egyptian : INation
    {
        Size housesize = new Housesize();
        Size treesize = new Treesize();
        Size watersourcesize = new EGPTWatersourcesize();
        public IObject Draw_house(Point lpbottom)
        {
            int height = housesize.GetHeight();
            int weidth = housesize.GetWeidth();
            IObject house = new Egyptian_house(lpbottom,height,weidth);
            return house;        
        }

        public IObject Draw_tree(Point mptop)
        {
            IObject tree = new Egyptian_tree(mptop);
            return tree;       
        }

        public IObject Draw_watersource(Point mptop)
        {
            IObject watersource = new Egyptian_watersource(mptop);
            return watersource;
        }

        public Color get_backcolor()
        {
            return Color.LightYellow;
        }
    }
}
