﻿using System.Drawing;

namespace ageOfVillagers
{
    internal class Circle
    {
        private int x, y, radius,XupperLeft, YupperLeft, height, width;
        Graphics g;
        Pen p;
        public Circle(Graphics g,Pen p,int x, int y, int radius)
        {
            this.g = g;
            this.p = p;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public void Draw()
        {
            XupperLeft = x - radius;
            YupperLeft = y - radius;
            height = 2 * radius;
            width = 2 * radius;
            Arc a = new Arc(g,p,XupperLeft,YupperLeft,height, width, 0, 360);
            a.Draw();
        }
    }
}