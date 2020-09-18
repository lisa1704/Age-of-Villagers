using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
        public void DrawWaterSource(Graphics g, Point point)
        {
            //NullValuesHandler nullArab = new NullValuesHandler();
            //nullArab.execute();
            System.Windows.Forms.MessageBox.Show("Invalid!!");
        }
    }
}
