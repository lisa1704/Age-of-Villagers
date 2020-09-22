using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NullWaterSource : IWaterSource
    {
        public void draw(MouseEventArgs e)
        {
            MessageBox.Show("They can not create their water source");
        }
    }
}
