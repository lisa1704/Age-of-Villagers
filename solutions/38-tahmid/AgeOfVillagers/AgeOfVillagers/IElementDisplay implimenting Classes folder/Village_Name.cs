using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.IStateElements_implimentinf_folder
{
    class Village_Name : IElementDisplay
    {
        private Label villageNameLabel;
        private string villageName;

        public Village_Name(Label villageNameLabel, string villageName)
        {
            this.villageNameLabel = villageNameLabel;
            this.villageName = villageName;
        }

        public void displayElements()
        {
           
        }
    }
}
