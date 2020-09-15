using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Age_of_Villagers.Shape
{
    public class NewEllipse : CompositeShape
    {
        private readonly Point topLeft;
        private readonly Point bottomRight;

        public NewEllipse(Point _topleft,Point _bottomright)
        {
            this.topLeft = _topleft;
            this.bottomRight = _bottomright;
            AddComponent(new NewArc(topLeft.X, topLeft.Y, bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y, 0, 360));
        }


    }
}
