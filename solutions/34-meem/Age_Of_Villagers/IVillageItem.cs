﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public interface IVillageItem
    {
         public void Draw(Point e,Graphics g, Pen p);
        
    }
}
