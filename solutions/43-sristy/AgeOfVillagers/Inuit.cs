﻿using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Inuit : INation
    {
        Pen p = new Pen(Color.Black);
        public void Draw_house(Graphics g,int X, int Y)
        {
            g.DrawArc(p, X + 25, Y+25, 50, 50, 180, 180);
            g.DrawArc(p, X - 25, Y-25, 150, 150, 180, 180);
            g.DrawLine(p, X - 25, Y+50, X + 125, Y+50);
            
        }

        public void Draw_tree(Graphics g,int X, int Y)
        {
            
        }

        public void Draw_watersource(Graphics g,int X, int Y)
        {
            
        }
    }
}
