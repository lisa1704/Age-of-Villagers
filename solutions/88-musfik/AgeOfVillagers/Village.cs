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
        private String villageName;
        private INation nation;
        private List<Point> house_items, waterResource_items, tree_items;
        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
            tree_items = new List<Point>();
            house_items = new List<Point>();
            waterResource_items = new List<Point>();
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

        internal void SetState(VillageState state)
        {
            villageName = state.villageName;
            tree_items = state.trees;
            house_items = state.houses;
            waterResource_items = state.watersources;
        }
        internal void initiate(Graphics g, Pen p)
        {
            g.Clear(nation.getTerrainColor());
            
            foreach (var point in tree_items)
            { 
                DrawItem(g, p, point, nation.getTree(point));
            }
            foreach (var point in house_items)
            {
                DrawItem(g, p, point, nation.getHouse(point));
            }
            foreach (var point in waterResource_items)
            {
                DrawItem(g, p, point, nation.getWaterResource(point));
            }
        }
        internal void DrawItem(Graphics g, Pen p, Point point,IVillageItem item)
        {
            IShape shape = item.getItemShape(point);
            shape.Draw(g, p);
        }
        internal void AddTree(Graphics g, Pen p, Point point)
        {
            var tree = nation.getTree(point);
            tree_items.Add(point);
            DrawItem(g, p, point, tree);
        }
        internal void AddHouse(Graphics g, Pen p, Point point)
        {
            var house = nation.getHouse(point);
            house_items.Add(point);
            DrawItem(g, p, point, house);
        }
        internal void AddWaterResource(Graphics g, Pen p, Point point)
        {
            var water = nation.getWaterResource(point);
            waterResource_items.Add(point);
            DrawItem(g, p, point, water);
        }
        internal VillageState createState()
        {
            return new VillageState(villageName, tree_items, house_items, waterResource_items);
        }
    }

    internal class VillageState
    {
        public String villageName;
        public List<Point> trees, houses, watersources;

        public VillageState(String villageName, List<Point> trees, List<Point> houses, List<Point> watersources)
        {
            this.villageName = villageName;
            this.watersources = watersources;
            this.houses = houses;
            this.trees = trees;
        }
    }
}
