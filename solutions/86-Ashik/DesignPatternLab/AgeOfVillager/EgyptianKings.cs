using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class EgyptianKings : INation
    {
        private readonly Graphics g;
        private readonly Form1 form;

        public EgyptianKings(Graphics graphics, Form1 form)
        {
            this.g = graphics;
            this.form = form;
        }

        public IHouse drawHouse(MouseEventArgs e)
        {
            return new EgyptianKingsHouse(g);
        }

        public ITree drawTree(MouseEventArgs e)
        {
            return new EgyptianKingsTree(g);
        }

        public void drawWaterSource(MouseEventArgs e)
        {
            EgyptianKingsWaterSource egyptianKingsWaterSource = new EgyptianKingsWaterSource(g);
            egyptianKingsWaterSource.draw(e);
        }
        public Color setColor()
        {
            form.BackColor = Color.FromArgb(250, 253, 2);
            return form.BackColor;
        }
    }
}
