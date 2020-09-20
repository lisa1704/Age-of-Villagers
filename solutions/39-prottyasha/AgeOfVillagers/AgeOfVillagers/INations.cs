using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INations
    {
        public void drawtree(Point p, Graphics g);
        public void drawhouse(Point p, Graphics g);
        public void drawwatersource(Point p, Graphics g);
    }
}
