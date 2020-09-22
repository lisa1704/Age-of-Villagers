using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class ArabBedouin : INation
    {
        private readonly Graphics g;
        private readonly Form1 form;

        public ArabBedouin(Graphics graphics, Form1 form)
        {
            this.g = graphics;
            this.form = form;
        }

        public IHouse drawHouse(MouseEventArgs e)
        {
            return new ArabBedouinsHouse(g);
        }

        public ITree drawTree(MouseEventArgs e)
        {
            return new ArabBedouinsTree(g);
        }

        public IWaterSource drawWaterSource(MouseEventArgs e)
        {
            throw new Exception();
            //MessageBox.Show("Bedouin villages do not build their own water source");
        }
        public Color setColor()
        {
            form.BackColor = Color.FromArgb(210, 213, 24);
            return form.BackColor;
        }
    }
}
