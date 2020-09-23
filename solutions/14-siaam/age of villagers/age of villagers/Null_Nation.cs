using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    public class Null_Nation : INation
    {
        public Color BgColor()
        {
            return Color.Empty;
        }

        public void drawHouse(Graphics g, Point point)
        {
            MessageBox.Show("Nation not selected or function not available");
        }

        public void drawTree(Graphics g, Point point)
        {
            MessageBox.Show("Nation not selected or function not available");
        }
    }
}
