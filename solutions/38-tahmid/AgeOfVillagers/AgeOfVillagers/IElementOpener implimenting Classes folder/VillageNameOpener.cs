using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.IStateElements_implimentinf_folder
{
    class VillageNameOpener : IElementOpener
    {
        private Label villageNameLabel;
        private string villageName;

        public VillageNameOpener(Label villageNameLabel, string villageName)
        {
            this.villageNameLabel = villageNameLabel;
            this.villageName = villageName;
        }

        public void displayElements()
        {
           
        }
    }
}
