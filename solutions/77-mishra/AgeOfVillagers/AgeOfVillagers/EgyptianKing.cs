﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        public void DrawHouse(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Point p, Panel drawingBoard)
        {
            throw new NotImplementedException();
        }

        public void PaintTerrain(Point p, Panel drawingBoard)
        {
            drawingBoard.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
