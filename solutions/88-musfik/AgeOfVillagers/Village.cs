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

        internal void AddTree(GraphicsWithPen gp, Point point)
        {
            var tree = nation.getItemShape(point, "Tree");
            tree.Draw(gp);
            tree_items.Add(point);
        }
        internal void AddHouse(GraphicsWithPen gp, Point point)
        {
            var house = nation.getItemShape(point, "House");
            house.Draw(gp);
            house_items.Add(point);
        }
        internal void AddWaterResource(GraphicsWithPen gp, Point point)
        {
            var water = nation.getItemShape(point, "Water");
            water.Draw(gp);
            waterResource_items.Add(point);
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

        internal void initiate(GraphicsWithPen gp)
        {
            gp.GetGraphics().Clear(nation.getTerrainColor());
            
            foreach (var point in tree_items)
            {
                var shape = nation.getItemShape(point, "Tree");
                shape.Draw(gp);
            }
            foreach (var point in house_items)
            {
                var shape = nation.getItemShape(point, "House");
                shape.Draw(gp);
            }
            foreach (var point in waterResource_items)
            {
                var shape = nation.getItemShape(point, "Water");
                shape.Draw(gp);
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
