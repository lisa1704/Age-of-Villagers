using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class BangladeshiFarmers : INation
    {
        private readonly Graphics g;
        private readonly Form1 form;

        public BangladeshiFarmers(Graphics graphics, Form1 form)
        {
            this.g = graphics;
            this.form = form;
        }

        public IHouse drawHouse(MouseEventArgs e)
        {
            return new BDFarmersHouse(g);
        }

        public ITree drawTree(MouseEventArgs e)
        {
            return new BDFarmersTree(g);
        }

        public IWaterSource drawWaterSource(MouseEventArgs e)
        {
            return new BDFarmersWaterSource(g);
        }
        public Color setColor()
        {
            form.BackColor = Color.FromArgb(70, 209, 0);
            return form.BackColor;
        }
    }
}
