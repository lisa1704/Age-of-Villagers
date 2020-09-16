using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface IShape
    {
        public void drawComponent(Point e, Graphics graphics, Pen pen);
    }
}
