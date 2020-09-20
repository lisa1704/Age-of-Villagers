﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    class ArabBedouin : AbstractNation
    {
        public ArabBedouin(Panel panel) : base(panel)
        {
            base.house = new ArabBedouinHouse();
            base.tree = new ArabBedouinTree();
            base.waterSource = new ArabBedouinWaterSource();
            base.color = System.Drawing.Color.LightYellow;
            colorBackground();
        }
    }
}