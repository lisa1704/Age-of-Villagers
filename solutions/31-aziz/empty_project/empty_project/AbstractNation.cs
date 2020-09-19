﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    abstract class AbstractNation : INation
    {
        protected IHouse house;
        protected ITree tree;
        protected IWaterSource waterSource;
        protected Panel panel;

        public AbstractNation(Panel panel)
        {
            this.panel = panel;
        }
        public void drawHouse(Axis axis)
        {
            house.drawHouse(axis, panel);
        }

        public void drawTree(Axis axis)
        {
            tree.drawTree(axis, panel);
        }

        public void drawWaterSource(Axis axis)
        {
            waterSource.drawWaterSource(axis, panel);
        }
    }
}
