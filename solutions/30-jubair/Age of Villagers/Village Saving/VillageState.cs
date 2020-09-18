using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_Villagers.Nation;

namespace Age_of_Villagers.Village_Saving
{
    public class VillageState
    
    {
        public List<Point> houseList = new List<Point>();
        public List<Point> treeList = new List<Point>();
        public List<Point> waterResourceList = new List<Point>();

        public string villageName ;

        public VillageState(string villageName)
        {
            this.villageName = villageName;

        }

        public void AddHouse(Graphics graphics, Point house, INation ination)
        
        {
            houseList.Add(house);
            ination.GetHouse(graphics,house);

        }


        public void AddTree(Graphics graphics, Point tree, INation ination)

        {
           treeList.Add(tree);
            ination.GetTree(graphics, tree);
        }


        public void AddWaterResource(Graphics graphics, Point waterResource, INation ination)

        {
           waterResourceList.Add(waterResource);
           ination.GetWaterResource(graphics, waterResource);
        }

    }
}
