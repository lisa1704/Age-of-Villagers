using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INations
    {
        public void setbgcolor(Graphics g);
        public void drawtree(Point p, Graphics g, Pen pen);
        public void drawhouse(Point p, Graphics g, Pen pen);
        public void drawwatersource(Point p, Graphics g, Pen pen);
    }
}
