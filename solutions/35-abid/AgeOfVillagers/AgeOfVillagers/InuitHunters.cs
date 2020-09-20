using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        private Panel drawingPanel;

        public InuitHunters(Panel drawingPanel)
        {
            this.drawingPanel = drawingPanel;
        }

        public void drawhouse(Point p)
        {
          
        }

        public void drawtree(Point p)
        {
            //no implementation
        }

        public void drawwatersrc(Point p)
        {
            //no implementation
        }
    }
}
