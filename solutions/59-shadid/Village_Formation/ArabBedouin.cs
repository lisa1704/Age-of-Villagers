using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Formation
{
    class ArabBedouin : INation
    {
        Pen mypen = new Pen(Color.Black, 2);
        Graphics g;

        public ArabBedouin(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 8, y - 8);
            g.DrawLine(mypen, x + 8, y - 8, x + 16, y);
           

        }

        public void DrawTree(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 16, y);
            g.DrawLine(mypen, x + 16, y, x + 16, y - 24);
            g.DrawLine(mypen, x + 16, y - 24, x, y - 24);
            g.DrawLine(mypen, x, y - 24, x, y);
            g.DrawLine(mypen, x, y, x, y+2);
            g.DrawLine(mypen, x, y, x +1, y +5);
            g.DrawLine(mypen, x, y, x + 3, y+7);
            g.DrawLine(mypen, x, y, x + 3, y + 7);
            g.DrawLine(mypen, x, y, x + 5, y + 9);
            g.DrawLine(mypen, x, y, x + 3, y + 7);

        }

        public void DrawWaterResource(MouseEventArgs e)
        {
            
        }

        public string NationName()
        {
            return "Arab Bedouins";
        }
    }
}
