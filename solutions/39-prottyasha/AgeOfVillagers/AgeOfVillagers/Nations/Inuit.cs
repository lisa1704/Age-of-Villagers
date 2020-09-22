using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Inuit : AbstractNation
    {
        public override IComponent getComponent(string component_type)
        {
            if (component_type == "house")
            {
                return new InuitHouse();
            }
            return null;
       
        }

        public override void setBgColor(Graphics g)
        {
            g.Clear(Color.White);
        }
    }
}
