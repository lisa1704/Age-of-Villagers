using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class VillageItem : IShape
    {
        protected Shape villageItemShape = new NoShape();

        public void Draw(Graphics g, Pen p)
        {
            villageItemShape.Draw(g, p);
        }

        public abstract Point GetPoint();
    }
}
