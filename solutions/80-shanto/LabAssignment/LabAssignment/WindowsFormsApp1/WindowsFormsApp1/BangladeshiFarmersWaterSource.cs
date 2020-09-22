using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarmersWaterSource : IWaterSource
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);
        public BangladeshiFarmersWaterSource(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 5, y + 4);
            g.DrawLine(mypen, x + 5, y + 4, x + 10, y - 6);
            g.DrawLine(mypen, x + 10, y - 6, x + 2, y - 10);
            g.DrawLine(mypen, x + 2, y - 10, x - 4, y - 6);
            g.DrawLine(mypen, x - 4, y - 6, x - 6, y - 9);
            g.DrawLine(mypen, x - 6, y - 9, x - 9, y - 7);
            g.DrawLine(mypen, x - 9, y - 7, x - 9, y);
            g.DrawLine(mypen, x - 9, y, x - 6, y + 5);
            g.DrawLine(mypen, x - 6, y + 5, x, y);
        }
    }
}
