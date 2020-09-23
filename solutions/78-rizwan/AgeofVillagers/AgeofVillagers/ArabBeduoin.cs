using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AgeofVillagers
{
    class ArabBeduoin : Ination
    {
        Graphics g;
        public ArabBeduoin(Graphics g)
        {
            this.g = g;
        }
        public void createHouse(MouseEventArgs e)
        {
            ArabHouse arabhouse = new ArabHouse(g);
            arabhouse.createHouse(e);
        }

        public void createTree(MouseEventArgs e)
        {
            ArabTree arabtree = new ArabTree(g);
            arabtree.createTree(e);
        }

        public void createWaterSource(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void terrain(Panel p)
        {
            p.BackColor = Color.LightYellow;
        }
    }
}
