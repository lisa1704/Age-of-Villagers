using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface INation
    {
        public void paint_house(MouseEventArgs e, Graphics g, Pen p);
        public void paint_tree(MouseEventArgs e, Graphics g, Pen p);
        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p);


    }
}
