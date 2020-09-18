using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.IStateElements_implimentinf_folder
{
    class VillageItems : IElementDisplay
    {
        List<IItem> itemList;
        public VillageItems() {
            itemList = new List<IItem>();
        }

        public void addItems(IItem item)
        {
            itemList.Add(item);
        }

        
        public void displayElements()
        {
            
        }
    }
}
