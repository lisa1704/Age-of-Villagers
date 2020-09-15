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
        public override void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            MessageBox.Show("Select a radio button!!");
        }

        public override Point getPoint()
        {
            //nullPoint.IsEmpty=true;
            return nullPoint;
        }
    }
}
