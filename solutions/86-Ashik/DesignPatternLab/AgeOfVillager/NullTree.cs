using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NullTree : ITree
    {
        public void draw(MouseEventArgs e)
        {
            MessageBox.Show("They can not plant trees");
        }
    }
}
