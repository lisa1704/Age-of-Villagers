using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class BangladeshiFarmers : Ination
    {
        Graphics g;
        public BangladeshiFarmers(Graphics g)
        {
            this.g = g;
        }
        
        public void createHouse(MouseEventArgs e)
        {
            BangladeshiHouse bh = new BangladeshiHouse(g);
            bh.createHouse(e);
        }

        public void createTree(MouseEventArgs e)
        {
            BangladeshiTree bt = new BangladeshiTree(g);
            bt.createTree(e);
        }

        public void createWaterSource(MouseEventArgs e)
        {
            BangladeshiWaterSource bws = new BangladeshiWaterSource(g);
            bws.createWaterSource(e);
        }
        public void terrain(Panel p)
        {
            p.BackColor = Color.Green;
        }
    }
}
