using System;

class InuitHunters : INation
{
    public void paint_house(MouseEventArgs e, Graphics g, Pen p)
    {
        int x, y;
        x = e.X;
        y = e.Y;

        Point pt2 = new Point(x + 8, y);
        Point pt3 = new Point(x - 8, y);
        g.DrawArc(p, x - 8, y - 8, 16, 16, 0, -180);
        g.DrawArc(p, x - 3, y - 3, 6, 6, 0, -180);
        g.DrawLine(p, pt2, pt3);
    }
}
