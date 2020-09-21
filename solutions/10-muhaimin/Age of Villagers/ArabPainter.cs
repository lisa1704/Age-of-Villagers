using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Age_of_Villagers
{
    public class ArabPainter : AbstractPainter
    {
        public ArabPainter(Panel panel) : base(panel)
        {
            base.house = new ArabHouse();
            base.tree = new ArabTree();
            base.wSource = new NullWaterSource();
            base.color = System.Drawing.Color.LightGoldenrodYellow;
            paintTerrain();
        }
    }
}
