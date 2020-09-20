using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarmers : INation
    {
        
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 2);
        public BangladeshiFarmers(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            BangladeshiFarrmersHouse bdh = new BangladeshiFarrmersHouse(g);
            bdh.Draw(e);
        }
        public void DrawTree(MouseEventArgs e)
        {
            BangladeshiFarmersTree bdt = new BangladeshiFarmersTree(g);
            bdt.Draw(e);
        }

        

        public void DrawWaterSource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 20, y + 16);
            g.DrawLine(mypen, x + 20, y + 16, x + 40, y - 24);
            g.DrawLine(mypen, x + 40, y - 24, x + 8, y - 40);
            g.DrawLine(mypen, x + 8, y - 40, x - 16, y - 24);
            g.DrawLine(mypen, x - 16, y - 24, x - 24, y - 36);
            g.DrawLine(mypen, x - 24, y - 36, x - 36, y - 28);
            g.DrawLine(mypen, x - 36, y - 28, x - 36, y);
            g.DrawLine(mypen, x - 36, y, x - 24, y + 20);
            g.DrawLine(mypen, x - 23, y + 20, x, y);
        }

        
    }
}
