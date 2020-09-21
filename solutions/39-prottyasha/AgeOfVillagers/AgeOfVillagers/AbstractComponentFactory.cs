using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public abstract class AbstractComponentFactory
    {
        public abstract IComponent getComponent(string component_type);
    }
}
