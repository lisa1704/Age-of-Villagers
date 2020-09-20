using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1_Test
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



            g.DrawLine(mypen, x + 25, y - 25, x + 50, y - 30);
            g.DrawLine(mypen, x + 50, y - 30, x + 70, y - 15);
            g.DrawLine(mypen, x + 50, y, x + 70, y - 15);

            g.DrawLine(mypen, x, y, x + 25, y - 25);
            g.DrawLine(mypen, x + 25, y - 25, x + 50, y);
            g.DrawLine(mypen, x, y, x + 50, y);
        }
    }
}
