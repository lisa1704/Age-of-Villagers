using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Arab : AbstractNation
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

        public override void setBgColor(Graphics g)
        {
            g.Clear(Color.Gold);
        }
    }
}
