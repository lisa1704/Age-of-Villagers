using AgeOfVillagers.Interface;
using AgeOfVillagers.IStateElements_implimentinf_folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    class ElementOpenerFactory
    {
        public IElementOpener GetElementOpener(String hint,String selectedNation,List<IItem> itemList)
        {
            return new VillageItemsOpener(itemList, selectedNation);
        }
        public IElementOpener GetElementOpener(String hint,Label VillageNameLabel,String villageName)
        {
            return new VillageNameOpener(VillageNameLabel, villageName);
        }
    }
}
