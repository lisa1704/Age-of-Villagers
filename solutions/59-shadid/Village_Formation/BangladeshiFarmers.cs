using System.Drawing;
using System.Windows.Forms;

namespace Village_Formation
{
    class BangladeshiFarmers : INation
    {
        Pen mypen = new Pen(Color.Black, 2);
        Graphics g;

        public BangladeshiFarmers(Graphics g)
        {
            this.g = g;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawRectangle(mypen, x, y, 16, 16);
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
            g.DrawArc(mypen, x + 2, y - 30, 25, 25, 0, 360);

        }

        public void DrawWaterResource(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 24, y + 16);
            g.DrawLine(mypen, x + 24, y + 16, x + 29, y + 18);
            g.DrawLine(mypen, x + 29, y + 18, x + 34, y - 16);
            g.DrawLine(mypen, x + 34, y - 16, x + 41, y - 13);
            g.DrawLine(mypen, x + 41, y - 13, x + 51, y - 17);
        }
    }
}

        
    


