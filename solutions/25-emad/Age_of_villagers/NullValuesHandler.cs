using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Age_of_villagers
{
    class NullValuesHandler : INations
    {
        public void DrawHouse(Graphics g, Point point)
        {
            MessageBox.Show("House not available for this nation");
          
        }

        public Color DrawBackground()
        {
            MessageBox.Show("Terrain not available for this nation");
            return Color.Empty;
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Tree not available for this nation");
            
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Water not available for this nation");
            
        }

    }
}
