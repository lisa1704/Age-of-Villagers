using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class BangladeshiFarmers : INation
    {
        private readonly Graphics g;
        
        public BangladeshiFarmers(Graphics graphics)
        {
            this.g = graphics;
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
    }
}
