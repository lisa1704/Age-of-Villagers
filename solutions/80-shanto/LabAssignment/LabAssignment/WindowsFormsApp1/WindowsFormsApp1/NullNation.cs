using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class NullNation : INation
    {
        Graphics g;

        public Color drawcolor()
        {
            return Color.White;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            
        }

        public void DrawTree(MouseEventArgs e)
        {
            NullTree nt = new NullTree(g);
            nt.Draw(e);
        }

        public void DrawWaterSource(MouseEventArgs e)
        {
            NullWaterSource nw = new NullWaterSource(g);
            nw.Draw(e);
        }
    }

    public class NullWaterSource : IWaterSource
    {
        private Graphics g;

        public NullWaterSource(Graphics g)
        {
            this.g = g;
        }

        public void Draw(MouseEventArgs e)
        {
            MessageBox.Show("null");
        }
    }




}
