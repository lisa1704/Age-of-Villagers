using System;
using System.Collections.Generic;
using AgeOfVillagers.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class Village_Item : IShapes
    {
        private readonly List<IShapes> v_item;
        public Village_Item()
        {
            v_item = new List<IShapes>();
        }

        protected void Add_item(IShapes shape)
        {
            v_item.Add(shape);
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
