using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class InuitHunters : INation
    {
        private readonly Graphics g;
        private readonly Form1 form;

        public InuitHunters(Graphics graphics, Form1 form)
        {
            this.g = graphics;
            this.form = form;
        }

        public void drawHouse(MouseEventArgs e)
        {
            InuitHuntersHouse inuitHuntersHouse = new InuitHuntersHouse(g);
            inuitHuntersHouse.draw(e);
        }

        public void drawTree(MouseEventArgs e)
        {
            MessageBox.Show("Trees can not be planted");
        }

        public void drawWaterSource(MouseEventArgs e)
        {
            MessageBox.Show("Relies on natural water sources so it is not possible to place water sources");
        }
        public Color setColor()
        {
            form.BackColor = Color.FromArgb(246, 246, 236);
            return form.BackColor;
        }
    }
}
