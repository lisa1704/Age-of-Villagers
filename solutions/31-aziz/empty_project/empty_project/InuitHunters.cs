using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class InuitHunters : AbstractNation
    {
        public InuitHunters(Panel panel) : base(panel)
        {
            base.house = new InuitHuntersHouse();
            base.tree = new InuitHuntersTree();
            base.waterSource = new InuitHuntersWaterSource();
            base.color = System.Drawing.Color.White;
            colorBackground();
        }
    }
}
