using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class ArabBedouinWaterSource : IWaterSource
    {
        public void drawWaterSource(Axis axis, Panel panel)
        {
            MessageBox.Show("We don't build our own water source :'( ");
        }
    }
}
