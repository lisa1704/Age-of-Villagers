using System;
using System.Drawing;

public class BangladeshiFarmersWaterSource : IWaterSource
{
    Pen p = new Pen(Color.White);
    public void drawWaterSource(Graphics g, int X, int Y)
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
