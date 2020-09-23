using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Formation
{
    class ArabBedouin : INation
    {
        Pen mypen = new Pen(Color.Black, 2);
        Graphics g;
        public void DrawHouse(MouseEventArgs e)
        {
           
        }

        public void DrawTree(MouseEventArgs e)
        {
            
        }

        public void DrawWaterResource(MouseEventArgs e)
        {
            
        }

        public string NationName()
        {
            return "Arab Bedouins";
        }
    }
}
