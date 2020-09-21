using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Egypt : AbstractComponentFactory
    {
        public override IComponent getComponent(string component_type)
        {
            if (component_type == "tree")
            {
                return new EgyptTree();
            }
            if (component_type == "house")
            {
                return new EgyptHouse();
            }
            if (component_type == "water_source")
            {
                return new EgyptRiver();
            }
        }
    }
}
