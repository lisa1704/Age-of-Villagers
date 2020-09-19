using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class InuitHunters : INation
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public InuitHunters(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawArc(mypen, x - 25, y - 25, 50, 50, 0, -180);
            g.DrawArc(mypen, x - 50, y - 50, 100, 100, 0, -180);
            g.DrawLine(mypen, x - 50, y , x +50 , y );
        }

        public void DrawTree(MouseEventArgs e)
        {
            
        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            
        }
    }
}
