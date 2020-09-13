using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
   public interface INation
    {
        void DrawHouse(Graphics g, int X, int Y);
        void DrawTrees(Graphics g, int X, int Y);

        void DrawWaterSources(Graphics g, int X, int Y);
    }
}
