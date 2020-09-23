using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class HunterTree : IShape
    {
        public HunterTree(Point start)
        {

        }
        public void Draw(Graphics gfx, Pen p)
        {
            // No trees on ice!
        }
    }
}
