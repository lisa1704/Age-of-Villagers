using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class KingHouse : IShape
    {
        List<Line> LineList = new List<Line>();
        public KingHouse(Point start)
        {
            Point end = start;
            end.Y = end.Y - 12;
            end.X = end.X + 6;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X + 10;
            end.Y = end.Y + 8;
            LineList.Add(new Line(start, end));
            start = end;
            end.X = end.X - 6;
            end.Y = end.Y + 8;
            LineList.Add(new Line(start, end));
            start = end;
            end.Y = end.Y-16;
            end.X = end.X - 4;
            LineList.Add(new Line(start, end));
            end.X = end.X - 6;
            end.Y = end.Y + 12;
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
