﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class AbstractNationFactoryCreator
    {
        string GetNationName
        {
            get;
            set;
        }
        public abstract INation CreateNation();
    }
}