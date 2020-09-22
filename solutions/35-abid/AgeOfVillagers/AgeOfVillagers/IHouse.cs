using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface IHouse
    {
        void drawHouse(Point p, Panel panel);
    }
}
