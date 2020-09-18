using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NationManager
    {
        private readonly string myNation;
        private Graphics g;

        public NationManager(string myNation, Graphics graphics)
        {
            this.myNation = myNation;
            this.g = graphics;
        }

        public void Draw(MouseEventArgs e)
        {
            
        }
    }
}
