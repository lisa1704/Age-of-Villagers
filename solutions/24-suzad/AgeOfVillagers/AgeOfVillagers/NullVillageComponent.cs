using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullVillageComponent : VillageComponent
    {
        Point nullPoint=new Point();
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            MessageBox.Show("Select proper radio button and proper nation!!");
        }

        public override Point getPoint()
        {
            return nullPoint;
        }
    }
}
