using System;
using System.Drawing;

public class ArabBedouinHouse : IHouse
{
    Pen p = new Pen(Color.Black);
    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X, Y + 50, X + 25, Y);
        g.DrawLine(p, X + 25, Y, X + 50, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X, Y + 50);
        g.DrawLine(p, X + 25, Y, X + 75, Y - 25);
        g.DrawLine(p, X + 75, Y - 25, X + 100, Y + 25);
        g.DrawLine(p, X + 100, Y + 25, X + 50, Y + 50);
    }
}
