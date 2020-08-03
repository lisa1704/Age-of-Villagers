using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi : INation
    {
        Pen p = new Pen(Color.Green);
        public void Draw_house(Graphics g,int X, int Y)
        {
            g.DrawLine(p, X, Y + 25, X + 25, Y);
            g.DrawLine(p, X + 25, Y, X + 50, Y + 25);
            g.DrawLine(p, X, Y + 25, X+50, Y +25);
            g.DrawLine(p, X + 50, Y + 25, X +50, Y+50);
            g.DrawLine(p, X + 50, Y + 50, X, Y+50);
            g.DrawLine(p, X, Y + 50, X, Y + 25);
        }
        public void Draw_tree(Graphics g,int X, int Y)
        { 
            g.DrawArc(p, X+25, Y, 50 ,50, 0, 360);

            g.DrawLine(p, X + 48, Y + 50, X + 52, Y +50);
            g.DrawLine(p, X + 52, Y + 50, X + 52, Y + 75);
            g.DrawLine(p, X + 52, Y + 75, X + 48, Y + 75);
            g.DrawLine(p, X + 48, Y + 75, X + 48, Y + 50);
        }
        public void Draw_watersource(Graphics g,int X, int Y)
        { 
            g.DrawLine(p, X, Y + 50, X + 25, Y + 25);
            g.DrawLine(p, X + 25, Y + 25, X + 50, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X + 75, Y);
            g.DrawLine(p, X + 75, Y, X + 50, Y - 25);
            g.DrawLine(p, X + 50, Y - 25, X + 25, Y);
            g.DrawLine(p, X + 25, Y, X + 25, Y - 25);
            g.DrawLine(p, X + 25, Y - 25, X, Y - 25);
            g.DrawLine(p, X, Y - 25, X - 25, Y + 25);
            g.DrawLine(p, X - 25, Y + 25, X, Y + 50);

        }
    }
}
