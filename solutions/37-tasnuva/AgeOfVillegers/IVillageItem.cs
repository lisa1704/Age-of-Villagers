﻿using System;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgeOfVillegers
{
   public  interface IVillageItem
    {
        void Draw(Point e,Graphics g, Pen p);
    }
}
