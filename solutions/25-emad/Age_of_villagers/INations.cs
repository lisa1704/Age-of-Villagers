using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Age_of_villagers
{
    public interface INations
    {
        void DrawTree(Graphics graphics, Point point);
        void DrawHouse(Graphics graphics, Point point);
        void DrawWaterSource(Graphics graphics, Point point);
        Color DrawBackground();

    }
}
