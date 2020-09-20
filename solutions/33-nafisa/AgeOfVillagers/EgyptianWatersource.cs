using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianWatersource : CompositeShape
    {
        private Panel Drawingpanel;

        public EgyptianWatersource(Point point)
        {
           addshape( new Arc( point.X, point.Y, 12, 12, 45, 360));
        }
        
    }
}
