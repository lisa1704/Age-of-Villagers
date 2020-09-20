using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    interface INation
    {
        void drawHouse(Axis axis);
        void drawTree(Axis axis);
        void drawWaterSource(Axis axis);
        void colorBackground();
    }
}
