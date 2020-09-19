using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.IStateElements_implimentinf_folder
{
    class VillageItems : IElementDisplay
    {
        List<IItem> itemList;
        private string selectedNation;

       

        public VillageItems(List<IItem> itemList, string selectedNation)
        {
            this.itemList = itemList;
            this.selectedNation = selectedNation;
        }

        public void displayElements()
        {
            
        }
    }
}
