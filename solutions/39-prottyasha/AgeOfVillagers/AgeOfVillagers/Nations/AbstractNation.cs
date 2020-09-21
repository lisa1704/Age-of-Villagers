using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class AbstractNation
    {
        public abstract IComponent getComponent(string component_type);
        public abstract void setBgColor(Graphics g);
    }
}
