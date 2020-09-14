using System;
using System.Drawing;

public class ArabBedouinTree : ITree
{
    Pen p = new Pen(Color.Black);


    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X + 48, Y + 50, X + 52, Y + 50);
        g.DrawLine(p, X + 52, Y + 50, X + 52, Y + 100);
        g.DrawLine(p, X + 52, Y + 100, X + 48, Y + 100);
        g.DrawLine(p, X + 48, Y + 100, X + 48, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X + 50, Y + 15);
        g.DrawLine(p, X + 50, Y + 50, X + 25, Y + 25);
        g.DrawLine(p, X + 50, Y + 50, X + 75, Y + 25);
        g.DrawLine(p, X + 50, Y + 50, X + 15, Y + 40);
        g.DrawLine(p, X + 50, Y + 50, X + 85, Y + 40);
    }
}
