using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public interface IShapeItem
    {
        void Paint(Graphics g, Pen p);
    }
}
