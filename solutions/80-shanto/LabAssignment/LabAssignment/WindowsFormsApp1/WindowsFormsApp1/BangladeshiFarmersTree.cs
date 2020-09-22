using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarmersTree : ITree
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);
        public BangladeshiFarmersTree(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(mypen, x - 6, y - 6,12 , 12, 0, 360);
            g.DrawLine(mypen, x - 1, y, x + 1, y);
            g.DrawLine(mypen, x + 1, y, x + 1, y + 12);
            g.DrawLine(mypen, x + 1, y + 12, x - 1, y + 12);
            g.DrawLine(mypen, x - 1, y + 12, x - 1, y);
        }
    }
}
