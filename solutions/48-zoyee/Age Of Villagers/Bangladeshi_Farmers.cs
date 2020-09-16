using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Bangladeshi_Farmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void DrawHouse(Graphics g, Point point)
        {
            g.DrawLine(p, point.X, point.Y, 100, 100);
        }

        public void Draw_Tree()
        {
            throw new NotImplementedException();
        }

        public void Draw_WaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
