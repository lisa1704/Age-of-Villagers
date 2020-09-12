using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class EgyptianPainter : AbstractPainter
    {
        public EgyptianPainter(Panel panel) : base(panel)
        {
            base.house = new EgyptianHouse();
            base.tree = new EgyptianTree();
            base.wSource = new EgyptianWaterSource();
            base.color = System.Drawing.Color.LightYellow;
        }
    }
}
