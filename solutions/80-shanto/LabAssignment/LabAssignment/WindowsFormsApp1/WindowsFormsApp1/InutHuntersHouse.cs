using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class InutHuntersHouse : IHouse
    {

        private readonly Graphics g;
        Pen mypen = new Pen(Color.Black, 1);

        public InutHuntersHouse(Graphics g)
        {
            this.g = g;
        }
        public void Draw(MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawArc(mypen, x - 4, y - 4 ,8, 8, 0, -180);
            g.DrawArc(mypen, x - 8, y - 8, 16, 16, 0, -180);
            g.DrawLine(mypen, x - 8, y, x + 8, y);
        }
    }
    
}
