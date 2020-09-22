using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        protected Panel drawingPanel;
        protected IHouse house = new InuitHouse();
        protected ITree tree = new NullTree();
        protected IWatersrc waterSrc = new InuitWatersrc();

        public InuitHunters(Panel panel)
        {
            drawingPanel = panel;
        }

        public void drawhouse(Point p)
        {
            house.drawHouse(p, drawingPanel);
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
