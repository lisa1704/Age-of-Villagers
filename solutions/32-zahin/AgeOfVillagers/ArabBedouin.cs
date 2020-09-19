using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBedouin : INation
    {
        private string item;

        public ArabBedouin()
        {

        }

        public void DrawHouse(Graphics g, Point point)
        {
            MessageBox.Show("Drawing House for Arab Bedouin");
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Drawing Tree for Arab Bedouin");
        }
        public void DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
        }
    }
}
