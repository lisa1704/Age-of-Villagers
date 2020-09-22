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

        public void drawHouse(MouseEventArgs e)
        {
            ArabBedouinsHouse arabBedouinsHouse = new ArabBedouinsHouse(g);
            arabBedouinsHouse.draw(e);
        }

        public ITree drawTree(MouseEventArgs e)
        {
            return new ArabBedouinsTree(g);
            //arabBedouinsTree.draw(e);
        }

        public void drawWaterSource(MouseEventArgs e)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
        }
        public Color setColor()
        {
            form.BackColor = Color.FromArgb(210, 213, 24);
            return form.BackColor;
        }
    }
}
