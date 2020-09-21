using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Bangladesh : AbstractComponentFactory
    {
        public override IComponent getComponent(string component_type)
        {
            if (component_type == "tree")
            {
                return new BdTree();
            }
            if (component_type == "house")
            {
                return new BdHouse();
            }
            if (component_type == "water_source")
            {
                return new BdRiver();
            }
            return null;

        }
    }
}
