using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public interface IWaterSource
    {
        void drawWaterSource(Axis axis, Panel panel);
    }
}
