using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void Draw(Graphics g, Pen p);
    }
}
