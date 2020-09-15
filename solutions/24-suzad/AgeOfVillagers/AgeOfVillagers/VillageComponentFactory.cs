using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public abstract class VillageComponentFactory
    {
        public abstract VillageComponent getComponent(string radiobtn, Point e);
    }
}
