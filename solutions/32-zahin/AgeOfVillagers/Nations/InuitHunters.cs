using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        private string item;

        public InuitHunters()
        {

        }
        public void DrawHouse(Graphics g, Point point)
        {
            MessageBox.Show("Drawing House for Inuit Hunters");
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Inuit Hunters can not plant trees");
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            var message = new StringBuilder();
            MessageBox.Show("Inuit Hunters relies on natural water sources so it is not possible to place water sources");

        }
    }
}
