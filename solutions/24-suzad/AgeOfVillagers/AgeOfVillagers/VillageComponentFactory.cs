﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public abstract class VillageComponentFactory
    {
        public abstract IVillageComponent getComponent(string radiobtn);
    }
}
