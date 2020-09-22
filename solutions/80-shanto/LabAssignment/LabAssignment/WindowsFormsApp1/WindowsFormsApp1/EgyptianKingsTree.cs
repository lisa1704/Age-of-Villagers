using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class EgyptianKingsTree : ITree
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);
        public EgyptianKingsTree(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 8, y - 12);
            g.DrawLine(mypen, x, y, x - 8, y - 12);
            g.DrawLine(mypen, x + 8, y - 12, x + 4, y - 24);
            g.DrawLine(mypen, x + 8, y - 12, x + 20, y - 24);
            g.DrawLine(mypen, x + 8, y - 12, x + 16, y - 24);
            g.DrawLine(mypen, x - 8, y - 12, x - 20, y - 24);
            g.DrawLine(mypen, x - 8, y - 12, x - 16, y - 24);
            g.DrawLine(mypen, x - 8, y - 12, x - 4, y - 24);
        }
    }

}
