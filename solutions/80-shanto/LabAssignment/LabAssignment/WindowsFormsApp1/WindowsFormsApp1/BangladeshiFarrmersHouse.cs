using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class BangladeshiFarrmersHouse : IHouse
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 2);
        public BangladeshiFarrmersHouse(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawLine(mypen, x, y, x + 50, y);
            g.DrawLine(mypen, x + 50, y, x + 50, y + 25);
            g.DrawLine(mypen, x + 50, y + 25, x, y + 25);
            g.DrawLine(mypen, x, y + 25, x, y);
            g.DrawLine(mypen, x, y, x + 25, y - 25);
            g.DrawLine(mypen, x + 25, y - 25, x + 50, y);
        }
    }
}
