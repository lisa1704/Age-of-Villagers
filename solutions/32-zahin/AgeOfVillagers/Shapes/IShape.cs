﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillagers.Shapes
{
    interface IShape
    {
       void DrawShape(Graphics g, Point point);
    }
}
