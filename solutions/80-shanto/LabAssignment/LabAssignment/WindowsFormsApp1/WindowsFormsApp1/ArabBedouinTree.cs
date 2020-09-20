using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ArabBedouinTree : ITree
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public ArabBedouinTree(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawLine(mypen, x, y, x + 40, y - 10);
            g.DrawLine(mypen, x, y, x - 40, y - 10);

            g.DrawLine(mypen, x, y, x + 20, y - 30);
            g.DrawLine(mypen, x, y, x - 20, y - 30);
            g.DrawLine(mypen, x, y, x, y - 30);

            g.DrawLine(mypen, x - 1, y, x + 1, y);
            g.DrawLine(mypen, x + 1, y, x + 1, y + 50);
            g.DrawLine(mypen, x + 1, y + 50, x - 1, y + 50);
            g.DrawLine(mypen, x - 1, y + 50, x - 1, y);

        }
    }

}
