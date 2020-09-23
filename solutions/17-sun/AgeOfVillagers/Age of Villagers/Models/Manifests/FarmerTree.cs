using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class FarmerTree : IShape
    {
        List<Line> LineList = new List<Line>();
        List<Arc> ArcList = new List<Arc>();
        public FarmerTree(Point start)
        {
            
            start.X = start.X + 8;
            Point end = start;
            end.Y = end.Y - 16;
            LineList.Add(new Line(start, end));
            start = end;
            Point center = start;
            center.X = center.X-8;
            center.Y = center.Y - 8;
            ArcList.Add(new Arc(center, 16, 16, 0, 360));
            end.Y = end.Y + 16;
            end.X = end.X + 1;
            start.X = start.X + 1;
            LineList.Add(new Line(start,end));
        }
        public void Draw(Graphics gfx, Pen p)
        {
            foreach (Line iLine in LineList)
            {
                iLine.Draw(gfx, p);
            }
            foreach(Arc iArc in ArcList)
            {
                iArc.Draw(gfx, p);
            }
        }
    }
}
