﻿using System.Collections.Generic;
using System.Drawing;

namespace Age_of_Villagers
{
    public class Arab : INation
    {
        private readonly List<Point> house_points = new List<Point>();
        private readonly List<Point> tree_points = new List<Point>();
        private readonly List<Point> river_points = new List<Point>();
        private IShape tree, house, river;
        private string village_name;
        private Graphics g;
        private Pen pen = new Pen(Color.Black);
        public void set_graphics(Graphics g)
        {
            this.g = g;
        }

        public void set_villagename(string name)
        {
            village_name = name;
        }

        public void draw_house(Point p)
        {
            house_points.Add(p);
            house = new Arhouse(p, 50, 20);
            house.draw(g,pen);
        }

        public void draw_river(Point P)
        {
            river = nullshape.Instance;            
            river.draw(g,pen);
        }

        public void draw_tree(Point p)
        {
            tree_points.Add(p);
            tree = new Artree(p,50,20);
            tree.draw(g, pen);
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
            return Color.LightYellow;
        }
    }

}
