﻿using System;
namespace age_of_villagers
{ 
    internal class NationFactory
    {
        public static Shape GetNation(string NationName)
        {
            if (Nation_Name == "Bangladeshi_Farmer")
                return new BdFactory();

            return null;
        }
    }
}
