﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    interface IHouse
    {
        void draw(Axes axes, Panel drawingSpace);
    }
}
