using AgeOfVillagers.Interface;
using AgeOfVillagers.IStateElements_implimentinf_folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    class ElementDisplayFactoryClass
    {
        public IElementDisplay GetStateElements(String hint)
        {
            return new VillageItems();
        }
        public IElementDisplay GetStateElements(String hint,Label VillageNameLabel,String villageName)
        {
            return new Village_Name(VillageNameLabel, villageName);
        }
    }
}
