using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers
{
    class Bangladesh :INation
    {
        List<Point> all_points = new List<Point>();
        Point mouse_point;
        string village_name;
        public Bangladesh()
        {
            
        }
        public void set_villagename(string name)
        {
            village_name = name;
        }

        public void draw_tree(Point p)
        {
            throw new System.NotImplementedException();
        }

        public void draw_house(Point p)
        {
            throw new System.NotImplementedException();
        }

        public void draw_river(Point P)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
