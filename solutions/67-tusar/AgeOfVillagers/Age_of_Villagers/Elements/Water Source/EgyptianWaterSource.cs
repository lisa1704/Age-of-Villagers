﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class EgyptianWaterSource : IWaterSource
    {
        public void drawWaterSource(Axes axes, Panel drawingSpace)
        {
            Pen pen = new Pen(Color.Black);
            Graphics elem = drawingSpace.CreateGraphics();

            elem.DrawEllipse(pen, axes.X, axes.Y, 12, 12);
        }
    }
}
