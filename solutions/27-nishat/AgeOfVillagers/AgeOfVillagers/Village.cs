using System;
using System.Collections.Generic;
using System.Drawing;

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
            return new Villagestate(villagename, trees, houses, watersources);
        }

        internal void SetState(IState state)
        {
            Villagestate villagestate = (Villagestate)state;
            villagename = villagestate.GetVillageName();
            trees = villagestate.trees;
            houses = villagestate.houses;
            watersources = villagestate.watersources;
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
    public interface IState
    {
        void SetVillageName(string villagename);
        String GetVillageName();
    }
    public class Villagestate : IState
    {
        public string villagename;
        public List<VillageItem> trees, houses, watersources;

        public Villagestate(string villagename, List<VillageItem> trees, List<VillageItem> houses, List<VillageItem> watersources)
        {
            this.villagename = villagename;
            this.watersources = watersources;
            this.houses = houses;
            this.trees = trees;
        }

        public string GetVillageName()
        {
            return villagename;
        }

        public void SetVillageName(string villagename)
        {
            this.villagename = villagename;
        }
    }
}
