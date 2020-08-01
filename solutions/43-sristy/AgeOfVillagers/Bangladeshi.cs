using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi : INation
    {
        Pen p = new Pen(Color.Black);
        public void Draw_house(Graphics g,int X, int Y)
        {
            g.DrawRectangle(p, X - 50, Y - 50, 100, 100);
        }
        public void Draw_tree(Graphics g,int X, int Y)
        {
            g.DrawEllipse(p, X - 50, Y - 50, 100, 100);
        }
        public void Draw_watersource(Graphics g,int X, int Y)
        {
            g.DrawEllipse(p, X - 50, Y - 50, 100, 100);
        }
    }
}
