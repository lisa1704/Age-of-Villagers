using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class NullComponentFactory : VillageComponentFactory
    {
        public override VillageComponent getComponent(string radiobtn, Point e)
        {
            return new NullVillageComponent();
        }
    }
}
