using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Ellipse : Composite
    {
        public Ellipse(Point TopLeft, Point BottomRight)
        {
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y, 0, 360));
        }
    }
}
public class Arc : IShape
{
    public int x, y;
    private float Start_Angle, Sweep_Angle, width, height;
    public Arc(int x, int y, float startAngle, float sweepAngle, float width, float height )
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.Start_Angle = startAngle;
        this.Sweep_Angle = sweepAngle;
    }
    public void Draw(Graphics g)
    {
        var pen = new Pen(Color.Black, 1);
        g.DrawArc(pen, x, y, width, height, Start_Angle, Sweep_Angle);
    }
}