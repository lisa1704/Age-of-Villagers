using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKingRiver : VillageComponent
    {
        public Point e;
        public EgyptianKingRiver(Point e)
        {
            this.e = e;

            Point point = new Point(e.X - 6, e.Y - 6);
            int width = 12;
            int height = 12;

            addComponent(new Circle(point, height, width));
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
