using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface INation
    {
        public Color getBackgroundColor();
        public IComponent getComponent(string component_type);
    }
}
