using AgeOfVillagers.Interface;
using AgeOfVillagers.IStateElements_implimentinf_folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    class ElementOpenerFactory
    {
        public IElementOpener GetElementOpener(String hint,String selectedNation,List<IItem> itemList,Graphics graphics,Pen pen)
        {
            return new VillageItemsOpener(itemList, selectedNation, graphics, pen);
        }
        public IElementOpener GetElementOpener(String hint,Label VillageNameLabel,String villageName)
        {
            return new VillageNameOpener(VillageNameLabel, villageName);
        }
    }
}
