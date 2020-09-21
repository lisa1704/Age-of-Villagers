using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Age_of_villagers
{
    class NullvalueHandler : INations
    {
        public string DrawHouse(Graphics graphics, Point point)
        {
            MessageBox.Show("No house available for this Nation");
            return "No house available for this Nation";
        }

        public string DrawWaterSource(Graphics graphics, Point point)
        {
            MessageBox.Show("No house available for this Nation");
            return "No house available for this Nation";
        }

        public string DrawTree(Graphics graphics, Point point)
        {
            MessageBox.Show("No house available for this Nation");
            return "No house available for this Nation";
        }


        public Color DrawTerrain()
        {
            MessageBox.Show("No house available for this Nation");
            return Color.Empty;
        }

        public Color DrawBackground()
        {
            throw new NotImplementedException();
        }
    }
}