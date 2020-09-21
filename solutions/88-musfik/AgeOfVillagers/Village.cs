using System;
using System.Collections.Generic;
using System.Drawing;

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

        internal void AddTree(Graphics g, Pen p, Point point)
        {
            var tree = nation.getItemShape(point, "Tree");
            tree_items.Add(point);
            tree.Draw(g, p);
            //DrawItem(g, p, point, tree);
        }
        internal void AddHouse(Graphics g, Pen p, Point point)
        {
            var house = nation.getItemShape(point, "House");
            house_items.Add(point);
            house.Draw(g, p);
            //DrawItem(g, p, point, house);
        }
        internal void AddWaterResource(Graphics g, Pen p, Point point)
        {
            var water = nation.getItemShape(point, "Water");
            waterResource_items.Add(point);
            water.Draw(g, p);
            //DrawItem(g, p, point, water);
        }

        private void DrawItem(Graphics g, Pen p, Point point, IVillageItem item)
        {
            IShape shape = item.getItemShape(point);
            shape.Draw(g, p);
        }

        public string GetVillageName()
        {
            return villageName;
        }
        public void SetVillageName(string value)
        {
            villageName = value;
        }

        public void ChangeVillageNation(INation nation)
        {
            this.nation = nation;
        }

        internal void initiate(Graphics g, Pen p)
        {
            g.Clear(nation.getTerrainColor());
            
            foreach (var point in tree_items)
            {
                var shape = nation.getItemShape(point, "Tree");
                shape.Draw(g, p);
                //DrawItem(g, p, point, nation.getTree(point));
            }
            foreach (var point in house_items)
            {
                var shape = nation.getItemShape(point, "House");
                shape.Draw(g, p);
                //DrawItem(g, p, point, nation.getHouse(point));
            }
            foreach (var point in waterResource_items)
            {
                var shape = nation.getItemShape(point, "Water");
                shape.Draw(g, p);
                //DrawItem(g, p, point, nation.getWaterResource(point));
            }
        }

        internal void SetState(VillageState state)
        {
            villageName = state.villageName;
            tree_items = state.trees;
            house_items = state.houses;
            waterResource_items = state.watersources;
        }
        internal VillageState CreateState()
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
