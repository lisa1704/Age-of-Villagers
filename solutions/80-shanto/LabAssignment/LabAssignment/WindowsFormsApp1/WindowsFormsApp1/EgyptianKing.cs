using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class EgyptianKing : INation
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public EgyptianKing(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            EgyptianKingsHouse ekh = new EgyptianKingsHouse(g);
            ekh.Draw(e);
        }

        public void DrawTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 12, y - 48);
            g.DrawLine(mypen, x, y, x - 8, y - 48);
            g.DrawLine(mypen, x + 12, y - 48, x + 32, y - 96);
            g.DrawLine(mypen, x + 12, y - 48, x + 20, y - 96);
            g.DrawLine(mypen, x + 12, y - 48, x + 8, y - 96);
            g.DrawLine(mypen, x - 8, y - 48, x - 32, y - 96);
            g.DrawLine(mypen, x - 8, y - 48, x - 16, y - 96);
            g.DrawLine(mypen, x - 8, y - 48, x - 4, y - 96);
        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(mypen, x - 20, y - 20, 40, 40, 0, 360);
        }
    }
}
