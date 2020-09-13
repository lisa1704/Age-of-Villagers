using System.Collections.Generic;
using System.Drawing;


namespace Age_of_Villagers
{
    class Egypt : INation
    {
        private List<Point> house_points = new List<Point>();
        private List<Point> tree_points = new List<Point>();
        private List<Point> river_points = new List<Point>();
        private IShape tree, house, river;
        private string village_name;
        private Graphics g;
        private Pen pen;
        public void set_graphics(Graphics g)
        {
            this.g = g;
        }
        
        public void set_villagename(string name)
        {
            village_name = name;
        }

        public void draw_tree(Point p)
        {
            tree_points.Add(p);
            pen = new Pen(Color.Black);
            tree = new Egtree(p, 40, 20);
            tree.draw(g, pen);
        }

        public void draw_house(Point p)
        {
            house_points.Add(p);
            house = new Eghouse(p, 40, 30);
            pen = new Pen(Color.Yellow);
            house.draw(g, pen);
        }

        public void draw_river(Point p)
        {
            river_points.Add(p);
            pen = new Pen(Color.Black);
            river = new circle(p,30);
            river.draw(g, pen);
        }

        public string get_villagename()
        {
            return village_name;
        }

        public List<Point> get_tree()
        {
            return tree_points;
        }

        public List<Point> get_house()
        {
            return house_points;
        }

        public List<Point> get_river()
        {
            return river_points;
        }
    }
}
