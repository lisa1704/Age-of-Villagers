using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
