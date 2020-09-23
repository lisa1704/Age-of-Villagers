using System.Drawing;

namespace AOV
{
    public abstract class VillageItem : IDraw
    {
        protected CompoundShape villageItemShape = new NullShape();
        public void draw(Graphics g)
        {
            villageItemShape.draw(g);
        }
        public abstract Point GetPoint();
    }
}
