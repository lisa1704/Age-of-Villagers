using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Village_Formation
{
    class InuitHunters : INation
    {
        Pen mypen = new Pen(Color.Black, 2);
        Graphics g;
        

        public InuitHunters(Graphics g)
        {
            this.g = g;
        }
        public void DrawHouse(MouseEventArgs e)
        {
            Rectangle rect = new Rectangle(10, 10, 320, 320);
            g.DrawArc(new Pen(new SolidBrush(Color.Black), 5), rect, 0, 90);
            g.DrawArc(new Pen(new SolidBrush(Color.Black), 5), rect, 270, 180);
        }

        public void DrawTree(MouseEventArgs e)
        {
            
        }

        public void DrawWaterResource(MouseEventArgs e)
        {
           
        }
        public string NationName()
        {
            return "Bangladeshi Farmers";
        }
    }
}
