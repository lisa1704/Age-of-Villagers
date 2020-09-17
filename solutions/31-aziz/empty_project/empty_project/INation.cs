using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace empty_project
{
    public interface INation
    {
        void DrawTree();
        void DrawHouse(Graphics graphics, Point point);
        void DrawWaterSource();

    }
}
