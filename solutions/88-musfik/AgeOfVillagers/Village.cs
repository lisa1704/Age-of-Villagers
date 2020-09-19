using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Village
    {
        private string villageName;
        private INation nation;
        private List<House> house_items;
        private List<WaterResource> waterResource_items;
        private List<Tree> tree_items;
        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
            tree_items = new List<Tree>();
            house_items = new List<House>();
            waterResource_items = new List<WaterResource>();
        }
        public void changeVillageNation(INation nation)
        {
            this.nation = nation;
        }
        public string GetVillageName()
        {
            return villageName;
        }

        public void SetVillageName(string value)
        {
            villageName = value;
        }

        internal void initiate(Graphics g, Pen p)
        {
            g.Clear(nation.getTerrainColor());
            for (int i = 0; i < tree_items.Count; i++)
            {
                Point point = tree_items[i].getItemLocation();
                tree_items[i] = nation.getTree(point);
                IShape shape = tree_items[i].getItemShape(point);
                shape.Draw(g, p);
            }
            for (int i = 0; i < house_items.Count; i++)
            {
                Point point = house_items[i].getItemLocation();
                house_items[i] = nation.getHouse(point);
                IShape shape = house_items[i].getItemShape(point);
                shape.Draw(g, p);
            }
            for (int i = 0; i < waterResource_items.Count; i++)
            {
                Point point = waterResource_items[i].getItemLocation();
                waterResource_items[i] = nation.getWaterResource(point);
                IShape shape = waterResource_items[i].getItemShape(point);
                shape.Draw(g, p);
            }
        }
        internal void DrawTree(Graphics g, Pen p, Point point)
        {
            var tree = nation.getTree(point);
            IShape shape = tree.getItemShape(point);
            shape.Draw(g, p);

            tree_items.Add(tree);
        }
        
        internal void DrawHouse(Graphics g, Pen p, Point point)
        {
            var house = nation.getHouse(point);
            IShape shape = house.getItemShape(point);
            shape.Draw(g, p);

            house_items.Add(house);
        }

        internal void DrawWaterResource(Graphics g, Pen p, Point point)
        {
            var water = nation.getWaterResource(point);
            IShape shape = water.getItemShape(point);
            shape.Draw(g, p);

            waterResource_items.Add(water);
        }
    }
}
