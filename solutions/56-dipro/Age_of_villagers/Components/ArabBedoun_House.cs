using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers.Components
{
    class ArabBedoun_House : VillageComponent
    {
        public Point makePoint(int x, int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawLine(pen, p, makePoint(p.X - 8, p.Y + 16));
            g.DrawLine(pen, p, makePoint(p.X + 8, p.Y + 16));
            g.DrawLine(pen, makePoint(p.X - 8, p.Y + 16), makePoint(p.X + 8, p.Y + 16));
            g.DrawLine(pen, p, makePoint(p.X + 8, p.Y - 3));
            g.DrawLine(pen, makePoint(p.X + 8, p.Y - 3), makePoint(p.X + 16, p.Y + 13));
            g.DrawLine(pen, makePoint(p.X + 8, p.Y + 16), makePoint(p.X + 16, p.Y + 13));
        }
    }
}
