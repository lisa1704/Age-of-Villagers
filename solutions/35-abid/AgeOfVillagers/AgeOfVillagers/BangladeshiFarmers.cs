using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        protected Panel drawingPanel;
        protected IHouse house = new BangladeshiHouse();
        protected ITree tree = new BangladeshiTree();
        protected IWatersrc waterSrc = new BangladeshiWatersrc();

        public BangladeshiFarmers(Panel panel)
        {
            drawingPanel = panel;
        }

        public void drawtree(Point p)
        {
            tree.drawTree(p, drawingPanel);
        }

        public void drawhouse(Point p)
        {
            house.drawHouse(p, drawingPanel);
        }

        public void drawwatersrc(Point p)
        {
            waterSrc.drawWatersrc(p, drawingPanel);
        }

        public IHouse getHouseType()
        {
            return this.house;
        }

        public ITree getTreeType()
        {
            return this.tree;
        }

        public IWatersrc getWatersrcType()
        {
            return this.waterSrc;
        }
    }
}
