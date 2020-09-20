using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    interface IHouse
    {
        void Draw(MouseEventArgs e);
    }

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
            g.DrawLine(mypen, x, y, x + 24, y - 28);
            g.DrawLine(mypen, x + 24, y - 28, x - 12, y - 64);
            g.DrawLine(mypen, x - 12, y - 64, x - 40, y - 16);
            g.DrawLine(mypen, x - 40, y - 16, x, y);
            g.DrawLine(mypen, x - 12, y - 64, x, y);
        }
    }
}
