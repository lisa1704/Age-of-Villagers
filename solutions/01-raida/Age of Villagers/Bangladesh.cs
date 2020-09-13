using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers
{
    class Bangladesh :INation
    {
        List<Point> all_points = new List<Point>();
        //Point mouse_point;
        IShape tree,house,river;
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
            tree = new Bdtree(p,30,30);
            tree.draw(g, pen);
        }

        public void draw_house(Point p)
        {
            house = new Bdhouse(p,30,20);
            house.draw(g,pen);
        }

        public void draw_river(Point p)
        {
            river = new Bdriver(p);
            river.draw(g, pen);
        }
    }
    
}
