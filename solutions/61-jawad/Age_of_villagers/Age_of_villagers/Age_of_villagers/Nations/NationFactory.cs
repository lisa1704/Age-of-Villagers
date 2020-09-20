﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_villagers.Nations
{
    class NationFactory
    {
        string nationName;
        public NationFactory(string NationType)
        {
            this.nationName = NationType;
        }
        public INation getNation()
        {
            if (nationName == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            return null;
        }
    }
}
