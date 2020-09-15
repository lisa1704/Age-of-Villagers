﻿using System;
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
        }
        public override void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            int x = e.X;
            int y = e.Y;
            graphics.DrawArc(pen, x - 6, y - 6, 12, 12, 0, 360);
        }

        public override Point getPoint()
        {
            return e;
        }
    }
}
