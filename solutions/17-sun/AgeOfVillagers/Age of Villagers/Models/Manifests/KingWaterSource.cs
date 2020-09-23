using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class KingWaterSource : IShape
    {
        Arc well;
        public KingWaterSource(Point start)
        {
            well=new Arc(start, 12, 12, 0, 360);
        }

        public void Draw(Graphics gfx, Pen p)
        {
            well.Draw(gfx, p);
        }
    }
}
