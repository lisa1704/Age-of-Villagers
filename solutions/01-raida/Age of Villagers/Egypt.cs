﻿using System.Collections.Generic;
using System.Drawing;


namespace Age_of_Villagers
{
    public class Egypt : INation
    {
        private readonly List<Point> house_points = new List<Point>();
        private readonly List<Point> tree_points = new List<Point>();
        private readonly List<Point> river_points = new List<Point>();
        private IShape tree, house, river;
        private string village_name;
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public void set_graphics(Graphics g)
        {
            this.g = g;
        }
        public void set_villagename(string name)
        {
            village_name = name;
        }

        public IShape draw_tree(Point p)
        {
            tree_points.Add(p);
            tree = new Egtree(p, 40, 20);
            if (g != null)
                tree.draw(g,pen);
            return tree;
        }

        public IShape draw_house(Point p)
        {
            house_points.Add(p);
            house = new Eghouse(p, 40, 30);
            if (g != null)
                house.draw(g, pen);
            return house;
        }

        public IShape draw_river(Point p)
        {
            river_points.Add(p);
            river = new circle(p,30);
            if (g != null)
                river.draw(g, pen);
            return river;
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

        public Color set_background()
        {
            return Color.PaleGoldenrod;
        }
    }
}