using System;
using System.Drawing;

public class InuitHuntersHouse : IHouse
{
    Pen p = new Pen(Color.Black);
    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X + 25, Y + 25, 50, 50, 180, 180);
        g.DrawArc(p, X - 25, Y - 25, 150, 150, 180, 180);
        g.DrawLine(p, X - 25, Y + 50, X + 125, Y + 50);
    }
}
