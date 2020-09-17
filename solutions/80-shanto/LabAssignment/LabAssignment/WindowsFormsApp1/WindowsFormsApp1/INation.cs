using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface INation
    {
        void DrawHouse();
        void DrawTree(Point e, Graphics graphics, Pen mypen);
        void DrawWaterSource();
    }


}
