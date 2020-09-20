using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NullItems : IShape
    {
        public void draw(Point p, Graphics g)
        {
            MessageBox.Show("No Available items");
        }
    }
}
