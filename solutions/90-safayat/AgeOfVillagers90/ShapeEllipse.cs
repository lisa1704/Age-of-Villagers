using System.Drawing;

namespace AgeOfVillagers90
{
    public class ShapeEllipse : CompositeShape
    {
        private readonly Point topleft;
        private readonly Point bottomright;

        public ShapeEllipse(Point topleft, Point bottomright)
        {
            this.topleft = topleft;
            this.bottomright = bottomright;
            AddComponent(new Arc(topleft.X, topleft.Y, bottomright.X - topleft.X, bottomright.Y - topleft.Y, 0, 360));
        }
    }
}
