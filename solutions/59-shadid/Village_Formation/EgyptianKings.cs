using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Formation
{
    class EgyptianKings : INation
    {
        Pen mypen = new Pen(Color.Black, 2);
        Graphics g;

        public EgyptianKings(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x -8, y - 8);
            g.DrawLine(mypen, x, y, x + 12, y - 8);
            g.DrawLine(mypen, x, y, x + 16, y - 8);
            g.DrawLine(mypen, x-8, y-8, x + 8, y - 8);
            g.DrawLine(mypen, x+12, y-8, x + 8, y - 8);
        }


        public void DrawTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x - 4, y +8);
            g.DrawLine(mypen, x , y , x + 4, y + 8);

        }


        public void DrawWaterResource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(mypen, x, y, 12, 12, 0, 360);

        }
        public string NationName()
        {
            return "Egyptian Kings";
        }
    }
}
