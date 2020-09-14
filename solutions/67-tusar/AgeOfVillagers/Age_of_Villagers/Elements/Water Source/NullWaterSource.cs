using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class NullWaterSource : IWaterSource
    {
        public void drawWaterSource(Axes axes, Panel drawingSpace)
        {
            //paint nothing
        }
    }
}
