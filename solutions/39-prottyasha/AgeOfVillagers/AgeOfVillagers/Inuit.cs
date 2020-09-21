using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Inuit : AbstractComponentFactory
    {
        public override IComponent getComponent(string component_type)
        {
            if (component_type == "house")
            {
                return new InuitHouse();
            }
       
        }
    }
}
