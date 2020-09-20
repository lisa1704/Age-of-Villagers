using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    interface INation
    {
        public void drawtree(Point p);
        public void drawhouse(Point p);
        public void drawwatersrc(Point p);
    }
}
