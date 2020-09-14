using System;
using System.Drawing;

public class EgyptianKingsWaterSource : IWaterSource
{
    Pen p = new Pen(Color.Black);
    public void drawWaterSource(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X + 25, Y, 50, 50, 0, 360);
    }
}
