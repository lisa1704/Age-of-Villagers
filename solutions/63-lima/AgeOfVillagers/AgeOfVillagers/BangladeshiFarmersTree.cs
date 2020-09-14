using System;
using System.Drawing;

public class BangladeshiFarmersTree : ITree
{
    Pen p = new Pen(Color.White);
    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X + 25, Y, 50, 50, 0, 360);

        g.DrawLine(p, X + 48, Y + 50, X + 52, Y + 50);
        g.DrawLine(p, X + 52, Y + 50, X + 52, Y + 75);
        g.DrawLine(p, X + 52, Y + 75, X + 48, Y + 75);
        g.DrawLine(p, X + 48, Y + 75, X + 48, Y + 50);
    }
}
