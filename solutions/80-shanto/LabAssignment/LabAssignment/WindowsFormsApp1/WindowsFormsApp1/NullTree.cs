using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class NullTree : ITree
    {
        private Graphics g;

        public NullTree(Graphics g)
        {
            this.g = g;
        }

        public void Draw(MouseEventArgs e)
        {
            MessageBox.Show("null");
        }
    }




}
