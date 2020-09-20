using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    interface INation
    {
        public void drawtree(Point p, Graphics g, Pen pen);
        public void drawhouse(Point p, Graphics g, Pen pen);
        public void drawwatersrc(Point p, Graphics g, Pen pen);
    }
}
