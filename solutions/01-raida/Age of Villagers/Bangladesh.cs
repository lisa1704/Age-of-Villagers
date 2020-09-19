﻿using System.Collections.Generic;
using System.Drawing;


namespace Age_of_Villagers
{
    public class Bangladesh :INation
    {
        private readonly List<Point> house_points = new List<Point>();
        private readonly List<Point> tree_points = new List<Point>();
        private readonly List<Point> river_points = new List<Point>();
        private IShape tree,house,river;
        private string village_name;
        
        public void set_villagename(string name)
        {
            village_name = name;
        }

        public IShape draw_tree(Point p)
        {
            tree_points.Add(p);
            tree = new Bdtree(p,30,30);
            return tree;
            
        }

        public void draw_house(Point p)
        {
            house_points.Add(p);
            house = new Bdhouse(p,30,20);
            house.draw(g,pen);
        }

        public void draw_river(Point p)
        {
            river_points.Add(p);
            river = new Bdriver(p);
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

        public Color set_background()
        {
            return Color.LightGreen;
        }
    }

    
}
