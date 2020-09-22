using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Shape
{
    interface IShape
    {
        void AddComponent(IShape shape);
        void Draw(Graphics g, Pen p);
    }
}