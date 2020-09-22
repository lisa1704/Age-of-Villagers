using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ArabBedouinHouse : IHouse
    {
        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public ArabBedouinHouse(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;



            g.DrawLine(mypen, x + 8, y - 8, x + 16, y - 12);
            g.DrawLine(mypen,  x + 16, y - 12, x + 24, y - 6);
            g.DrawLine(mypen, x + 16, y, x + 24, y - 6);

            g.DrawLine(mypen, x, y, x + 8, y - 8);
            g.DrawLine(mypen, x + 8, y - 8, x + 16, y);
            g.DrawLine(mypen, x, y, x + 16, y);
        }
    }
}
