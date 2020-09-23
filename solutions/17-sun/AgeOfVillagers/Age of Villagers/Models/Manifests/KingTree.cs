using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class KingTree : IShape
    {
        List<Line> LineList = new List<Line>();
        public KingTree(Point start)
        {
            Point end = start;
            start.X = start.X + 8;
            end.Y = end.Y - 12;
            LineList.Add(new Line(start, end));
            Point left = end;
            Point tip = left;
            tip.Y = tip.Y - 10;
            tip.X = tip.X - 6;
            LineList.Add(new Line(left, tip));
            tip.X = tip.X - 4;
            LineList.Add(new Line(left, tip));
            tip.X = tip.X + 8;
            tip.Y = tip.Y - 2;
            LineList.Add(new Line(left, tip));

            end = start;
            end.Y = end.Y - 10;
            end.X = end.X + 4;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X + 4;
            end.Y = end.Y-12;
            LineList.Add(new Line(start, end));
            end.X = end.X + 4;
            end.Y = end.Y + 2;
            LineList.Add(new Line(start, end));
            end.X = end.X - 8;
            end.Y = end.Y - 2;
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
