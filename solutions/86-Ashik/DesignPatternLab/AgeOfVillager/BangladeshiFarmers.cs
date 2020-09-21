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

        public void drawHouse(MouseEventArgs e)
        {
            BDFarmersHouse bDFarmersHouse = new BDFarmersHouse(g);
            bDFarmersHouse.draw(e);
        }

        public void drawTree(MouseEventArgs e)
        {
            BDFarmersTree bDFarmersTree = new BDFarmersTree(g);
            bDFarmersTree.draw(e);
        }

        public void drawWaterSource(MouseEventArgs e)
        {
            BDFarmersWaterSource bDFarmersWaterSource = new BDFarmersWaterSource(g);
            bDFarmersWaterSource.draw(e);
        }
        public Color setColor()
        {
            form.BackColor = Color.FromArgb(70, 209, 0);
            return form.BackColor;
        }
    }
}
