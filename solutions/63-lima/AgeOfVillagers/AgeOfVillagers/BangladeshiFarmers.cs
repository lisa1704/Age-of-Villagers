using System;
using System.Drawing;
using System.Windows.Forms;

public class BangladeshiFarmers : INation
{
    Pen p = new Pen(Color.White);
    Panel panel;
    public BangladeshiFarmers(Panel panel)
    {
        this.panel = panel;
    }
    public void paintTerrain()
    {
        panel.BackColor = Color.Green;
    }0

    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X, Y + 25, X + 25, Y);
        g.DrawLine(p, X + 25, Y, X + 50, Y + 25);
        g.DrawLine(p, X, Y + 25, X + 50, Y + 25);
        g.DrawLine(p, X + 50, Y + 25, X + 50, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X, Y + 50);
        g.DrawLine(p, X, Y + 50, X, Y + 25);

    }

    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X + 25, Y, 50, 50, 0, 360);

        g.DrawLine(p, X + 48, Y + 50, X + 52, Y + 50);
        g.DrawLine(p, X + 52, Y + 50, X + 52, Y + 75);
        g.DrawLine(p, X + 52, Y + 75, X + 48, Y + 75);
        g.DrawLine(p, X + 48, Y + 75, X + 48, Y + 50);

    }

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
