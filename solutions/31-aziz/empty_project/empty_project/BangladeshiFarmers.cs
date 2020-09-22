using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class BangladeshiFarmers : AbstractNation
    {
        public BangladeshiFarmers(Panel panel) : base(panel)
        {
            base.house = new BangladeshiFarmersHouse();
            base.tree = new BangladeshiFarmersTree();
            base.waterSource = new BangladeshiFarmersWaterSource();
        }
        public override Color colorBackground()
        {
            base.color = System.Drawing.Color.Green;
            return panel.BackColor = color;
        }
    }
}
