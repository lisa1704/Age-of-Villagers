using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers
{
    class Bangladesh :INation
    {
        //List<Point> all_points = new List<Point>();
        //Point mouse_point;
        IShape tree;
        string village_name;
        Graphics g;
        Pen pen;
        public void set_graphics(Graphics g)
        {
            this.g = g;
        }
        public void set_pen(Pen pen)
        {
            this.pen = pen;
        }
        public void set_villagename(string name)
        {
            village_name = name;
        }

        public void draw_tree(Point p)
        {
            tree = new circle(p,50);
            tree.draw(g, pen);
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
