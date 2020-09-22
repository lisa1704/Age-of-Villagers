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

        public void drawHouse(MouseEventArgs e)
        {
            EgyptianKingsHouse egyptianKingsHouse = new EgyptianKingsHouse(g);
            egyptianKingsHouse.draw(e);
        }

        public ITree drawTree(MouseEventArgs e)
        {
            return new EgyptianKingsTree(g);
            //egyptianKingsTree.draw(e);
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
