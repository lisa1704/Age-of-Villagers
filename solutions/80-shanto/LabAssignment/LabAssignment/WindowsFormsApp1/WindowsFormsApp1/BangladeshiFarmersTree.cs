using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarmersTree : ITree
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 2);
        public BangladeshiFarmersTree(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(mypen, x - 25, y - 25, 50, 50, 0, 360);
            g.DrawLine(mypen, x - 1, y, x + 1, y);
            g.DrawLine(mypen, x + 1, y, x + 1, y + 50);
            g.DrawLine(mypen, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(mypen, x - 1, y + 50, x - 1, y);
        }
    }
}
