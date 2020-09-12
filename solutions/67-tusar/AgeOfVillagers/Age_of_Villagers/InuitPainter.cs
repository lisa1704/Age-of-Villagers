using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class InuitPainter : AbstractPainter
    {
        public InuitPainter(Panel panel) : base(panel)
        {
            base.house = new InuitHouse();
            base.tree = new NullTree();
            base.wSource = new NullWaterSource();
            base.color = System.Drawing.Color.White;
        }
    }
}
