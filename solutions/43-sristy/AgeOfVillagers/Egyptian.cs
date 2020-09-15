using System;
using System.Drawing;

namespace Age_of_villagers
{ 
    public class Egyptian : INation
    {
        Pen p = new Pen(Color.Yellow);
        public void Draw_house(Graphics g, Point lpbottom)
        {
            Compositeobj house = new Egyptian_house(lpbottom);
            house.paint(p, g);           
        }

        public void Draw_tree(Graphics g, Point mptop)
        {
            Compositeobj tree = new Egyptian_tree(mptop);
            tree.paint(p, g);          
        }

        public void Draw_watersource(Graphics g, Point mptop)
        {
            Compositeobj watersource = new Egyptian_watersource(mptop);
            watersource.paint(p, g);
        }

        public Color get_backcolor()
        {
            return Color.LightYellow;
        }
    }
}
