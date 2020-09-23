using System.Drawing;

namespace AOV
{
    public abstract class NationItem : IDraw
    {
        protected CompoundShape nationItemShape = new NullShape();
        public void Draw(Graphics g)
        {
            nationItemShape.Draw(g);
        }
        public abstract Point GetPoint();
    }
}
