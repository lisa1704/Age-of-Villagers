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
        private List<IVillageItem> house_items, waterResource_items, tree_items;
        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
            tree_items = new List<IVillageItem>();
            house_items = new List<IVillageItem>();
            waterResource_items = new List<IVillageItem>();
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
            tree_items = tree_items.ConvertAll(tree => tree = nation.getTree(tree.getItemLocation()));
            house_items = house_items.ConvertAll(house => house = nation.getHouse(house.getItemLocation()));
            waterResource_items = waterResource_items.ConvertAll(water => water = nation.getHouse(water.getItemLocation()));

            fetchItems(g, p, tree_items);
            fetchItems(g, p, house_items);
            fetchItems(g, p, waterResource_items);
        }
        internal void fetchItems(Graphics g, Pen p, List<IVillageItem> villageItems)
        {
            foreach( var item in villageItems)
            {
                Point point = item.getItemLocation();
                DrawItem(g, p, point, item);
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
            tree_items.Add(tree);
            DrawItem(g, p, point, tree);
        }
        internal void AddHouse(Graphics g, Pen p, Point point)
        {
            var house = nation.getHouse(point);
            house_items.Add(house);
            DrawItem(g, p, point, house);
        }
        internal void AddWaterResource(Graphics g, Pen p, Point point)
        {
            var water = nation.getWaterResource(point);
            waterResource_items.Add(water);
            DrawItem(g, p, point, water);
        }
    }
}
