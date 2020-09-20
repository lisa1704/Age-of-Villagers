using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_Villagers.Nation;

namespace Age_of_Villagers.Village_Saving
{
    public class VillageEdit : VillageState
    
    {

        public string villageName ;

        public VillageEdit(string villageName)
        {
            this.villageName = villageName;

        }

        public string GetVillageName()
        {
            return villageName;
        }
        public void SetVillageName(string name)
        {
            villageName = name;
        }




        public void ReDrawVillage(Graphics graphics, INation ination)
        {
            foreach (Point house in houseList)
            {
                ination.GetHouse(graphics, house);
            }

            foreach (Point tree in treeList)
            {
                ination.GetTree(graphics, tree);
            }

            foreach (Point waterResource in waterResourceList)
            {
                ination.GetWaterResource(graphics, waterResource);
            }
        }

    }
}
