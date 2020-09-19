using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class BangladeshiFarmers : AbstractNation
    {
        public BangladeshiFarmers(Panel panel) : base(panel)
        {
            base.house = new BangladeshiFarmersHouse();
            base.tree = new BangladeshiFarmersTree();
            base.waterSource = new BangladeshiFarmersWaterSource();
        }
    }
}
