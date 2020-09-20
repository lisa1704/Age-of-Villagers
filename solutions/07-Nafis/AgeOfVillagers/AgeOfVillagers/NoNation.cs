using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NoNation : INations
    {
        public void DrawHouse(int x, int y, Graphics g)
        {
            ShowError();
        }

        public void DrawTree(int x, int y, Graphics g)
        {
            ShowError();
        }

        public void DrawWater(int x, int y, Graphics g)
        {
            ShowError();
        }

        private void ShowError()
        {
            MessageBox.Show("Please select a Nation.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
