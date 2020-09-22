using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class InuitHunters : INation
    {

        private readonly Graphics g;
        public InuitHunters(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            InutHuntersHouse ihh = new InutHuntersHouse(g);
            ihh.Draw(e);
        }

        public void DrawTree(MouseEventArgs e)
        {
            NullTree nt = new NullTree(g);
            nt.Draw(e);
        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            NullWaterSource nw = new NullWaterSource(g);
            nw.Draw(e);
        }
        public Color drawcolor()
        {
            return Color.White;
        }
        public string NationName()
        {
            return "Inuit Hunters";
        }
    }
}
