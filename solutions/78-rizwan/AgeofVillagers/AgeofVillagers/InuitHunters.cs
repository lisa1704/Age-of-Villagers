using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AgeofVillagers
{

    class InuitHunters : Ination
    {
        Graphics g;
        public InuitHunters(Graphics g)
        {
            this.g = g;
        }

        public void createHouse(MouseEventArgs e)
        {
            InuitHouse inuithouse = new InuitHouse(g);
            inuithouse.createHouse(e);
        }

        public void createTree(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void createWaterSource(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void terrain(Panel p)
        {
            p.BackColor = Color.White;
        }
    }
}
