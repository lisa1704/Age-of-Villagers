using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ArabBedouin : INation
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public ArabBedouin(Graphics g)
        {
            this.g = g;
        }
        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;



            g.DrawLine(mypen, x+25, y-25, x + 50, y - 30);
            g.DrawLine(mypen, x + 50, y - 30, x + 70, y - 15);
            g.DrawLine(mypen, x+50, y, x + 70, y -15);

            g.DrawLine(mypen, x, y, x + 25, y - 25);
            g.DrawLine(mypen, x + 25, y - 25, x + 50, y);
            g.DrawLine(mypen, x , y , x + 50, y);

        }

        public void DrawTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawLine(mypen, x , y, x+40, y-10);
            g.DrawLine(mypen, x, y, x - 40, y - 10);

            g.DrawLine(mypen, x, y, x + 20, y - 30);
            g.DrawLine(mypen, x, y, x - 20, y - 30);
            g.DrawLine(mypen, x, y,x , y - 30);

            g.DrawLine(mypen, x - 1, y, x + 1, y);
            g.DrawLine(mypen, x + 1, y, x + 1, y + 50);
            g.DrawLine(mypen, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(mypen, x - 1, y + 50, x - 1, y);


        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
        }
    }
}
