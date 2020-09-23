using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AgeofVillagers
{
    public class EgyptianKing : Ination
    {
        Graphics g;
        public EgyptianKing(Graphics g)
        {
            this.g = g;
        }

        public void createHouse(MouseEventArgs e)
        {
            EgyptHouse egypthouse = new EgyptHouse(g);
            egypthouse.createHouse(e);
        }

        public void createTree(MouseEventArgs e)
        {
            EgyptTree egypttree = new EgyptTree(g);
            egypttree.createTree(e);
        }

        public void createWaterSource(MouseEventArgs e)
        {
            EgyptWater egyptwater = new EgyptWater(g);
            egyptwater.createWaterSource(e);
        }
        public Color terrain(Panel p)
        {
            p.BackColor = Color.Yellow;
            return Color.Yellow;
        }
    }
}
