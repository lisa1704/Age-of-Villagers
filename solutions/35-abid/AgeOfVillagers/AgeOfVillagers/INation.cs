using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface INation
    {
        public void drawtree(Point p);
        public void drawhouse(Point p);
        public void drawwatersrc(Point p);
        IHouse getHouseType();
        ITree getTreeType();
        IWatersrc getWatersrcType();

    }
}
