﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class ItemFactory
    {
        public abstract IVillageItem getItem(string button);
    }
}
