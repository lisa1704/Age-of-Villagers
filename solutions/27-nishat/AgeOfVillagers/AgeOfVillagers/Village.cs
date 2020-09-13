using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AgeOfVillagers
{
    public class Village
    {
        private INation nation;
        private string villagename;
        private List<VillageItem> trees, houses, watersources;

        public Village(INation nation, string villagename)
        {
            this.nation = nation;
            this.villagename = villagename;
            trees =  new List<VillageItem>();
            houses = new List<VillageItem>();
            watersources = new List<VillageItem>();
        }

        internal void initiate(Graphics g, Pen p)
        {
            g.Clear(nation.GetTerrainColor());
            foreach (var tree in trees)
            {
                tree.Draw(g, p);
            }
            foreach (var house in houses)
            {
                house.Draw(g, p);
            }
            foreach (var watersource in watersources)
            {
                watersource.Draw(g, p);
            }
        }

        internal IState GetState()
        {
            List<Point> treepoints,housepoinits,watersourcepoints;
            treepoints = trees.ConvertAll(x => x.GetPoint());
            housepoinits = houses.ConvertAll(x => x.GetPoint());
            watersourcepoints = watersources.ConvertAll(x => x.GetPoint());

            return new Villagestate(villagename, treepoints, housepoinits, watersourcepoints);
        }

        internal void SetState(IState state)
        {
            Villagestate villagestate = (Villagestate)state;
            villagename = villagestate.GetVillageName();
            trees = villagestate.trees.ConvertAll(x => nation.GetTree(x));
            houses = villagestate.houses.ConvertAll(x => nation.GetHouse(x));
            watersources = villagestate.watersources.ConvertAll(x => nation.GetWaterResource(x));
        }

        internal void DrawTree(Graphics g, Pen p, Point point)
        {
            VillageItem tree = nation.GetTree(point);
            trees.Add(tree);
            tree.Draw(g, p);
        }

        internal void DrawHouse(Graphics g, Pen p, Point point)
        {
            VillageItem house = nation.GetHouse(point);
            houses.Add(house);
            house.Draw(g, p);
        }

        internal void DrawWaterResource(Graphics g, Pen p, Point point)
        {
            VillageItem watersource = nation.GetWaterResource(point);
            watersources.Add(watersource);
            watersource.Draw(g, p);
        }
    }
}
