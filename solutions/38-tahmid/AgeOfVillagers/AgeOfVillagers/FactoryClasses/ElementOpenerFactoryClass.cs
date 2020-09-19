using AgeOfVillagers.Interface;
using AgeOfVillagers.IStateElements_implimentinf_folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    class ElementOpenerFactoryClass
    {
        public IElementDisplay GetElementOpener(String hint,String selectedNation,List<IItem> itemList)
        {
            return new VillageItems(itemList, selectedNation);
        }
        public IElementDisplay GetElementOpener(String hint,Label VillageNameLabel,String villageName)
        {
            return new Village_Name(VillageNameLabel, villageName);
        }
    }
}
