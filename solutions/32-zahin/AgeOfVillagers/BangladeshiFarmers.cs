using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        private string item;

        public BangladeshiFarmers()
        {
        }

        public void DrawHouse(Graphics g, Point point)
        {
            MessageBox.Show("Drawing House for Bangladeshi Farmers");
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Drawing Tree for Bangladeshi Farmers");
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            var message = new StringBuilder();
            MessageBox.Show("Drawing Water for Bangladeshi Farmers");
        }
    }
}
