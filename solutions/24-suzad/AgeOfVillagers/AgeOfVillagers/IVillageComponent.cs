using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface IVillageComponent
    {
        //public void drawComponent(MouseEventArgs e, Graphics graphics, Pen pen);
        public void drawComponent(Point e, Graphics graphics, Pen pen);
        public Point getPoint();
    }
}
