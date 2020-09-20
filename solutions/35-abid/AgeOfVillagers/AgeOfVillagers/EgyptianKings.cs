using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        protected Panel drawingPanel;
        protected IHouse house = new EgyptianHouse();
        protected ITree tree = new EgyptianTree();
        protected IWatersrc waterSrc = new EgyptianWatersrc();

        public EgyptianKings(Panel panel)
        {
            drawingPanel = panel;
        }

        public void drawhouse(Point p)
        {
            house.drawHouse(p, drawingPanel);
        }

        public void drawtree(Point p)
        {
            tree.drawTree(p, drawingPanel);
        }

        public void drawwatersrc(Point p)
        {
            waterSrc.drawWatersrc(p, drawingPanel);
        }
    }
}
