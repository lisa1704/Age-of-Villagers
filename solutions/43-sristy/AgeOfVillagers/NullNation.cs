using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
    public class NullNation : INation
    {
        public void Draw_house(Graphics g, Point p)
        {
            warning();
        }

        public void Draw_tree(Graphics g, Point p)
        {
            warning();
        }

        public void Draw_watersource(Graphics g, Point p)
        {
            warning();
        }

        public void warning()
        {
            DialogResult d;
            d = MessageBox.Show("VillgeType is not selected");
        }
    }
}
