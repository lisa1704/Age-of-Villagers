using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NullItemHandler:CompositeShape
    {
        public void Draw()
        {
            MessageBox.Show("Error. Null value");
        }
    }
}
