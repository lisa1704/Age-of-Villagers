using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class BangladeshiFarmers : INation
    {
        
        Graphics g;
        Pen mypen = new Pen(Color.Black, 2);
        public BangladeshiFarmers(Graphics g)
        {
            this.g = g;
        }
        public void DrawHouse(MouseEventArgs e)
        {
            BangladeshiFarrmersHouse bdh = new BangladeshiFarrmersHouse(g);
            bdh.Draw(e);
        }
        public Color drawcolor()
        {
            return Color.Green;
        }
        public void DrawTree(MouseEventArgs e)
        {
            BangladeshiFarmersTree bdt = new BangladeshiFarmersTree(g);
            bdt.Draw(e);
        }       
        public void DrawWaterSource(MouseEventArgs e)
        {
            BangladeshiFarmersWaterSource bdw = new BangladeshiFarmersWaterSource(g);
            bdw.Draw(e);
        }     
        
        public string NationName()
        {
            return "Bangladeshi Farmers";
        }
    }

}
