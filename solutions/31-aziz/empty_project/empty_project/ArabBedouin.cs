using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace empty_project
{
    class ArabBedouin : INation
    {
        Pen pen = new Pen(Color.Yellow);
        public void DrawHouse(Graphics graphics, Point point)
        {
            graphics.DrawLine(pen, point.X, point.Y, 100, 100);
        }

        void INation.DrawTree()
        {
            throw new NotImplementedException();
        }

        void INation.DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
