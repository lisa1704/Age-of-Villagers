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
        Pen mypen = new Pen(Color.Black, 2);

        public EgyptianKing(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            /*int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 30, y - 30);
            g.DrawLine(mypen, x, y, x - 30, y - 30);*/
        }

        public void DrawTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 30, y - 30);
            g.DrawLine(mypen, x, y, x - 30, y - 30);
        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
