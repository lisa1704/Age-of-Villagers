using System;
using System.Drawing;
using System.Windows.Forms;

public class InuitHunters : INation
{
    Pen p = new Pen(Color.Black);
    Panel panel;
    public InuitHunters(Panel panel)
    {
        this.panel = panel;
    }
    //public void drawTree(Graphics g, int X, int Y)
    //{
        
    //}

    //public void drawHouse(Graphics g, int X, int Y)
    //{
    //    g.DrawArc(p, X + 25, Y + 25, 50, 50, 180, 180);
    //    g.DrawArc(p, X - 25, Y - 25, 150, 150, 180, 180);
    //    g.DrawLine(p, X - 25, Y + 50, X + 125, Y + 50);
    //}

    //public void drawWaterSource(Graphics g, int X, int Y)
    //{
        
    //}



    public void paintTerrain()
    {
        panel.BackColor = Color.White;
    }
}
