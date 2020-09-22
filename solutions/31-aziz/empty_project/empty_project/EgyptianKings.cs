using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    public class EgyptianKings : AbstractNation
    {
        public EgyptianKings(Panel panel) : base(panel)
        {
            base.house = new EgyptianKingsHouse();
            base.tree = new EgyptianKingsTree();
            base.waterSource = new EgyptianKingsWaterSource();
        }
        public override Color colorBackground()
        {
            base.color = System.Drawing.Color.Yellow;
            return panel.BackColor = color;
        }
    }
}
