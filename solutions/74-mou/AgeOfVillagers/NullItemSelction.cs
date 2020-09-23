using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullItemSelction : CompositeShapes
    {
        public void DrawShapes()
        {
            MessageBox.Show("Not Valid!");
        }
    }
}
