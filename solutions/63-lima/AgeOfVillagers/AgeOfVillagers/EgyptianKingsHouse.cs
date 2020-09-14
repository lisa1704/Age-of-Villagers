using System;
using System.Drawing;

public class EgyptianKingsHouse : IHouse
{
    Pen p = new Pen(Color.Black);
    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X - 25, Y + 35, X + 25, Y - 25);
        g.DrawLine(p, X + 25, Y - 25, X + 50, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X - 25, Y + 35);
        g.DrawLine(p, X + 25, Y - 25, X + 75, Y + 25);
        g.DrawLine(p, X + 75, Y + 25, X + 50, Y + 50);
    }
}
