using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Age_of_villagers.Shape;


namespace Age_of_villagers.Components
{
    class InuitHunter_house : VillageComponent
    {
        private readonly Point top, mid_Left, mid_Right, bottom_Left, bottom_Right;
        private float x, y, width, height, start_Angle, sweep_Angle;
        public InuitHunter_house(Point top_Left, Point bottom_Right)
        {
            x = top_Left.X;
            y = top_Left.Y;
            width = bottom_Right.X - top_Left.X;
            height = bottom_Right.Y - top_Left.Y;
            start_Angle = 0;
            sweep_Angle = 180;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, start_Angle, sweep_Angle);
        }

    }
}
