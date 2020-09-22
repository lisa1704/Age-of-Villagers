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

            g.DrawLine(mypen, x, y, x + 16, y);
            g.DrawLine(mypen, x + 16, y, x + 16, y + 8);
            g.DrawLine(mypen, x + 16, y + 8, x, y + 8);
            g.DrawLine(mypen, x, y + 8, x, y);
            g.DrawLine(mypen, x, y, x + 8, y - 8);
            g.DrawLine(mypen, x + 8, y - 8, x + 16, y);
        }
    }
}
