using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;


namespace Age_of_Villagers
{
    class Bangladesh :INation
    {
        private List<Point> house_points = new List<Point>();
        private List<Point> tree_points = new List<Point>();
        private List<Point> river_points = new List<Point>();
        private IShape tree,house,river;
        private string village_name;
        private Graphics g;
        private Pen pen;
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
            tree_points.Add(p);
            tree = new Bdtree(p,30,30);
            tree.draw(g, pen);
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
    }

    interface ISaveVillage
    {
        void save(string path, INation nation);
    }

    struct village
    {
        public string name;
        public List<Point> tree_points;
        public List<Point> house_points;
        public List<Point> river_points;
    };

    class SaveVillage : ISaveVillage
    {
        village village;
        private void get_state(INation nation)
        {
            village.name = nation.get_villagename();
            village.tree_points = nation.get_tree();
            village.house_points = nation.get_house();
            village.river_points = nation.get_river();
        }

        public void save(string path, INation nation)
        {
            this.get_state(nation);
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, village);
            }
        }
    }

    interface IOpenVillage
    {
        void open(string path, INation nation);
    }

    class OpenVillage : IOpenVillage
    {
        village village;
        public void open(string path,INation nation)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                village= JsonConvert.DeserializeObject<village>(json);
            }
            this.set_state(nation);
        }

        private void set_state(INation nation)
        {
             nation.set_villagename(village.name);
            foreach (Point p in village.tree_points)
                nation.draw_tree(p);
            foreach (Point p in village.house_points)
                nation.draw_house(p);
            foreach (Point p in village.river_points)
                nation.draw_river(p);
            
        }
    }
}
