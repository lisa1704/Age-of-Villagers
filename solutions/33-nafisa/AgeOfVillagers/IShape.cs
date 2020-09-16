using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    interface IShape
    {
        void Draw(Point point, Panel Drawingpanel);
    }
}
