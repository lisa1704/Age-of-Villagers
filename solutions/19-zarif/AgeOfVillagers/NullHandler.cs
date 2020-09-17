using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullHandler : IGraphicShape
    {
        public void draw(Graphics g, Pen pen)
        {
            MessageBox.Show("Don't Have The Implementation");
        }
    }
}
