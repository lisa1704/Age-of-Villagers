using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class HunterHouse : IShape
    {
        List<Line> LineList = new List<Line>();
        List<Arc> ArcList = new List<Arc>();
        public HunterHouse(Point start)
        {
            Point end = start;
            end.X = end.X + 16;
            LineList.Add(new Line(start, end));
            start.Y = start.Y - 8;
            ArcList.Add(new Arc(start, 16, 16, 0, -180));
            start.X = start.X + 6;
            start.Y = start.Y + 6;
            ArcList.Add(new Arc(start, 4, 4, 0, -180));

        } 
        public void Draw(Graphics gfx, Pen p)
        {
            foreach (Line iLine in LineList)
            {
                iLine.Draw(gfx, p);
            }
            foreach (Arc iArc in ArcList)
            {
                iArc.Draw(gfx, p);
            }
        }
    }
}
