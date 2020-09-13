using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class VillageItem : IShape
    {
        public abstract void Draw(Graphics g, Pen p);

        public abstract Point GetPoint();
    }
}
