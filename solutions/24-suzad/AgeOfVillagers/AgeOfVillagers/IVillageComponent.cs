using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public abstract class VillageComponent:IShape
    {
        public readonly List<IShape> _components;
        public VillageComponent()
        {
            _components = new List<IShape>();
        }
        public void addComponent(IShape shape)
        {
            _components.Add(shape);
        }
        public void drawComponent(Point e, Graphics graphics, Pen pen)
        {
            foreach (var component in _components)
            {
                component.drawComponent( e,  graphics,  pen);
            }
        }
        public abstract Point getPoint();
    }
}
