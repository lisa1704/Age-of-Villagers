using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface IShapeItem
    {
        void Paint(Graphics g);
    }

    public abstract class CompositeShape : IShapeItem
    {
        private List<IShapeItem> SComponents;

        protected CompositeShape()
        {
            SComponents = new List<IShapeItem>();
        }

        public void AddComp(IShapeItem shape)
        {
            SComponents.Add(shape);
        }
        public void Paint(Graphics g)
        {
            foreach (var component in SComponents)
                component.Paint(g);
        }
    }
}
