using System.Collections.Generic;
using System.Drawing;


namespace Age_of_Villagers
{
    class Inuit : INation
    {
        private List<Point> house_points = new List<Point>();
        private List<Point> tree_points = new List<Point>();
        private List<Point> river_points = new List<Point>();
        private IShape tree, house, river;
        private string village_name;
        private Graphics g;
        private Pen pen= new Pen(Color.Black);
        public void draw_house(Point p)
        {
            house_points.Add(p);
            house = new igloo(p, 75,30);
            house.draw(g, pen);
        }

        public void draw_river(Point P)
        {
            river = nullshape.Instance;
            river.draw(g, pen);
        }

        public void draw_tree(Point p)
        {
            tree = nullshape.Instance;
            tree.draw(g, pen);
        }

        public List<Point> get_house()
        {
            return house_points;
        }

        public List<Point> get_river()
        {
            return river_points;
        }

        public List<Point> get_tree()
        {
            return tree_points;
        }

        public string get_villagename()
        {
            return village_name;
        }

        public void set_graphics(Graphics g)
        {
            this.g = g;
        }

        public void set_villagename(string name)
        {
            village_name = name;
        }
    }
}
