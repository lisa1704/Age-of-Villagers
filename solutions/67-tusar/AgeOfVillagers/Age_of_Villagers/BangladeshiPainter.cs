using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class BangladeshiPainter : AbstractPainter
    {
        public BangladeshiPainter(Panel panel) : base(panel)
        {
            base.house = new BangladeshiHouse();
            base.tree = new BangladeshiTree();
            base.wSource = new BangladeshiWaterSource();
            base.color = System.Drawing.Color.LightSeaGreen;
        }
    }
}
