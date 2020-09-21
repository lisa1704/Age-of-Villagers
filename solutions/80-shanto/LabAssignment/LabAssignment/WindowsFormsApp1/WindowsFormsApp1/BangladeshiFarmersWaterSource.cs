using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarmersWaterSource : IWaterSource
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 2);
        public BangladeshiFarmersWaterSource(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
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
