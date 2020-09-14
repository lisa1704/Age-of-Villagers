using System;
using System.Drawing;
using System.Windows.Forms;

public class EgyptianKings : INation
{
    Pen p = new Pen(Color.Black);
    Panel panel;
    public EgyptianKings(Panel panel)
    {
        this.panel = panel;
        //paintTerrain();
    }

    public void paintTerrain()
    {
        panel.BackColor = Color.Yellow ;
    }

    public void drawHouse(Graphics g, int X, int Y)
    {

        g.DrawLine(p, X - 25, Y + 35, X + 25, Y - 25);
        g.DrawLine(p, X + 25, Y - 25, X + 50, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X - 25, Y + 35);
        g.DrawLine(p, X + 25, Y - 25, X + 75, Y + 25);
        g.DrawLine(p, X + 75, Y + 25, X + 50, Y + 50);
    }


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

    public void drawWaterSource(Graphics g, int X, int Y)
    {
        g.DrawArc(p, X + 25, Y, 50, 50, 0, 360);
    }
}
