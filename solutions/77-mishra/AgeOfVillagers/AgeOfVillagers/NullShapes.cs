using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullShapes : CompositeShapes
    {
        private CompositeShapes cshape = new CompositeShapes();
        public void drawNull()
        {
            MessageBox.Show("Nothing available");
        }
    }
}
