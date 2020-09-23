using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class EllipseShape : CompositeShaping
    {
        private readonly Point topLeft;
        private readonly Point bottomRight;

        public EllipseShape(Point _topleft, Point _bottomright)
        {
            this.topLeft = _topleft;
            this.bottomRight = _bottomright;
            AddComponent(new ArcShape(topLeft.X, topLeft.Y, bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y, 0, 360));
        }

    }
}
