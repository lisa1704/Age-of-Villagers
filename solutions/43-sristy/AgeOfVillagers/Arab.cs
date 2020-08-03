using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Arab : INation
    {
        Pen p = new Pen(Color.Gold);
        public void Draw_house(Graphics g,int X, int Y)
        {
            g.DrawLine(p, X, Y + 50, X + 25, Y);
            g.DrawLine(p, X + 25, Y, X + 50, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X, Y + 50);
            g.DrawLine(p, X + 25, Y, X + 75, Y - 25);
            g.DrawLine(p, X + 75, Y - 25, X + 100, Y + 25);
            g.DrawLine(p, X + 100, Y + 25, X + 50, Y + 50);


        }

        public void Draw_tree(Graphics g,int X, int Y)
        {
            g.DrawLine(p, X + 48, Y + 50, X + 52, Y + 50);
            g.DrawLine(p, X + 52, Y + 50, X + 52, Y + 100);
            g.DrawLine(p, X + 52, Y + 100, X + 48, Y + 100);
            g.DrawLine(p, X + 48, Y + 100, X + 48, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X+50, Y+15);
            g.DrawLine(p, X + 50, Y + 50, X + 25, Y+25);
            g.DrawLine(p, X + 50, Y + 50, X + 75, Y+25);
            g.DrawLine(p, X + 50, Y + 50, X +15, Y+40);
            g.DrawLine(p, X + 50, Y + 50, X + 85, Y+40);
        }

        public void Draw_watersource(Graphics g,int X, int Y)
        {
            
        }
    }
}
