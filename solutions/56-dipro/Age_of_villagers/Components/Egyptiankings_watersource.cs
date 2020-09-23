using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Age_of_villagers.Shape;

namespace Age_of_villagers.Components
{
    class Egyptiankings_watersource :VillageComponent
    {
        private readonly Point top_Left ;
        private float x, y, width, height, start_Angle, sweep_Angle;
        public Egyptiankings_watersource(Point top_Left)
        {
            x = top_Left.X;
            y = top_Left.Y;
            width = 12;
            height = 12;
            start_Angle = 0;
            sweep_Angle = 360;
        }
        public void draw(Graphics g, Pen p)
        {
            g.DrawArc(p, x, y, width, height, start_Angle, sweep_Angle);
        }
    }
}
