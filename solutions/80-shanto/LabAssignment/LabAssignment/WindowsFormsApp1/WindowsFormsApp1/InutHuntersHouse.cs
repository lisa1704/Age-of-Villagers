using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class InutHuntersHouse : IHouse
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 2);

        public InutHuntersHouse(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawArc(mypen, x - 25, y - 25, 50, 50, 0, -180);
            g.DrawArc(mypen, x - 50, y - 50, 100, 100, 0, -180);
            g.DrawLine(mypen, x - 50, y, x + 50, y);
        }
    }
    
}
