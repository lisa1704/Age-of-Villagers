using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class EgyptianKingsHouse : IHouse
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public EgyptianKingsHouse(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(mypen, x, y, x + 6, y - 7);
            g.DrawLine(mypen, x + 6, y - 7, x - 3, y - 16);
            g.DrawLine(mypen, x - 3, y - 16, x - 10, y - 4);
            g.DrawLine(mypen, x - 10, y - 4, x, y);
            g.DrawLine(mypen, x - 3, y - 16, x, y);
        }
    }
}
