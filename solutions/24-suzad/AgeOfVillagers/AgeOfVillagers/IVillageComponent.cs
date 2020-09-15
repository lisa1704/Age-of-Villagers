using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public abstract class VillageComponent
    {
        //public void drawComponent(MouseEventArgs e, Graphics graphics, Pen pen);
        public abstract void drawComponent(Point e, Graphics graphics, Pen pen);
        public abstract Point getPoint();
    }
}
