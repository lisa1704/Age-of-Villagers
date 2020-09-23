using System.Drawing;

namespace AOV
{
    public abstract class NationItem : IDraw
    {
        protected CompoundShape nationItemShape = new NullShape();
        public void draw(Graphics g)
        {
            nationItemShape.draw(g);
        }
        public abstract Point GetPoint();
    }
}
