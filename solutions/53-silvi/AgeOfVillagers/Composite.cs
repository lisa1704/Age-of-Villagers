using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class Composite : Object
    {
        protected List<Object> My_components = new List<Object>();

        protected void AddComponent(Object myshape)
        {
            My_components.Add(myshape);
        }
        public void Draw(Graphics g)
        {
            foreach (var component in My_components)
            {
                component.Draw(g);
            }
        }
    }
}
