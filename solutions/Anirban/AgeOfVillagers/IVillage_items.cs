using System;
using System.Collections.Generic;
using AgeOfVillagers.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class VillageItem : IShapes
    {
        private readonly List<IShapes> v_item;
        public VillageItem()
        {
            v_item = new List<IShapes>();
        }

        public void Draw_shapes(Point pt, Graphics g, Pen p)
        {
            foreach (IShapes item in v_item)
            {
                item.Draw_shapes(pt, g, p);
            }
        }
        
    }
}
