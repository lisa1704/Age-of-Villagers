using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Arab : AbstractComponentFactory
    {
        public override IComponent getComponent(string component_type)
        {
            if (component_type == "tree")
            {
                return new ArabTree();
            }
            if (component_type == "house")
            {
                return new ArabHouse();
            }
            return null;

        }
    }
}
