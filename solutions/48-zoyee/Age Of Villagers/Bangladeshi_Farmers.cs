using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void Draw_Tree(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
        public void Draw_House(Graphics g, Point point)
        {
            g.DrawLine(p, point.X, point.Y, 100, 100);
        }
        public void Draw_WaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}