using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers
{
    class Bangladesh :INation
    {
        List<Point> all_points = new List<Point>();
        Point mouse_point;
        public Bangladesh(Point P)
        {
            mouse_point= P;
        }
        public void draw()
        {

        }
    }
    
}
