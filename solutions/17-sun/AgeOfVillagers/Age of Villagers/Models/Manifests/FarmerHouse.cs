using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers.Models.Manifests
{
     public class FarmerHouse : IShape
    {
        List<Line> LineList = new List<Line>();
        public FarmerHouse(Point start)
        {
            Point end = start;
            end.X = start.X + 16;
            LineList.Add(new Line(start, end));
            start = end;
            end.Y = start.Y - 8; 
            LineList.Add(new Line(start,end));
            start = end;
            end.X = start.X - 16;
            LineList.Add(new Line(start, end));
            start = end;
            end.Y = start.Y + 8;
            LineList.Add(new Line(start, end));
            start = end;
            start.Y = start.Y - 8;
            end.X = start.X + 8;
            end.Y = start.Y - 8;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = start.X + 8;
            end.Y = start.Y + 8;
            LineList.Add(new Line(start, end));
        }
        public void Draw(Graphics gfx, Pen p)
        {
            foreach(Line iLine in LineList)
            {
                iLine.Draw(gfx, p);
            }
        }
    }
}
