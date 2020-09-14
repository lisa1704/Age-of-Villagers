using System;
using System.Drawing;

public class EgyptianKingsTree : ITree
{
    Pen p = new Pen(Color.Black);

    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X + 50, Y + 50, X + 65, Y + 25);
        g.DrawLine(p, X + 50, Y + 50, X + 35, Y + 15);
        g.DrawLine(p, X + 65, Y + 25, X + 90, Y);
        g.DrawLine(p, X + 65, Y + 25, X + 65, Y);
        g.DrawLine(p, X + 65, Y + 25, X + 90, Y + 20);
        g.DrawLine(p, X + 35, Y + 15, X + 45, Y - 10);
        g.DrawLine(p, X + 35, Y + 15, X + 25, Y - 10);
        g.DrawLine(p, X + 35, Y + 15, X + 10, Y);
    }
}