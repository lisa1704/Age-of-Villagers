﻿using System;
using System.Collections.Generic;
using System.Text;

namespace age_of_villagers.age_of_village.Items.House
{
    class ArabBedouinHouse : Ihouse
    {
        public void createHouse(string item) {
            item = item + "arab";
        }
    }
}
