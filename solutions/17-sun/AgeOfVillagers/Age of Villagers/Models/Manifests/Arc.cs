using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class Arc : IShape
    {
        Rectangle rect = new Rectangle();
        
        int theta, alpha;
        public void Draw(Graphics gfx, Pen p)
        {
            gfx.DrawArc(p, rect, theta, alpha);
        }
    }
}
