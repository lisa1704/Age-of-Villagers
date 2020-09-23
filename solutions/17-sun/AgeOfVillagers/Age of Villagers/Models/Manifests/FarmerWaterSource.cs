using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class FarmerWaterSource : IShape
    {
        List<Line> LineList = new List<Line>();
        
        public FarmerWaterSource(Point start)

        {
            
            start.X = start.X + 8;
            Point end = start;
            end.X = end.X + 8;
            end.Y = end.Y - 4;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X + 4;
            end.Y = end.Y + 2;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X + 4;
            end.Y = end.Y - 8;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X - 4;
            end.Y = end.Y - 6;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X - 8;
            end.Y = end.Y + 6;
            LineList.Add(new Line(start, end));
            start = end;
            end.Y = end.Y - 4;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X -4;
            end.Y = end.Y + 2;
            LineList.Add(new Line(start, end));
            start = end;
            end.Y = end.Y + 6;
            end.X = end.X - 8;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X + 8;
            end.Y = end.Y + 6;
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
