using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class BedouinTree : IShape
    {
        List<Line> LineList = new List<Line>();
        public BedouinTree(Point start)
        {
            start.X = start.X + 8;
            Point end = start;
            end.Y = end.Y - 16;
            LineList.Add(new Line(start, end));
            start = end;
            Point center = start;
            Point tip = center;
            tip.Y = tip.Y - 8;
            LineList.Add(new Line(center, tip));
            tip = center;
            tip.Y = tip.Y - 6;
            tip.X = tip.X + 6;
            LineList.Add(new Line(center, tip));
            tip.X = tip.X - 12;
            LineList.Add(new Line(center, tip));
            tip.X = tip.X - 2;
            tip.Y = tip.Y + 4;
            LineList.Add(new Line(center, tip));
            tip.X = tip.X + 16;
            LineList.Add(new Line(center, tip));
            end.Y = end.Y + 16;
            end.X = end.X + 1;
            start.X = start.X + 1;
            LineList.Add(new Line(start, end));
        }

        public void Draw(Graphics gfx, Pen p)
        {
            foreach (Line iLine in LineList)
            {
                iLine.Draw(gfx, p);
            }
        }
    }
}
