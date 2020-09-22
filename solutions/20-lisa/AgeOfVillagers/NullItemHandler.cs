using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullItemHandler:CompositeShape
    {
        public void Draw()
        {
            MessageBox.Show("This component is null");
        }
    }
}
