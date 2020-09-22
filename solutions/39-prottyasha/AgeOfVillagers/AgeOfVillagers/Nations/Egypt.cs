using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Egypt : AbstractNation
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
            return null;
        }

        public override void setBgColor(Graphics g)
        {
            g.Clear(Color.Yellow);
        }
    }
}
