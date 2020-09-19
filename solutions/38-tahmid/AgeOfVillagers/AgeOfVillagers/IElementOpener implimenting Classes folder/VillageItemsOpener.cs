using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IStateElements_implimentinf_folder
{
    class VillageItemsOpener : IElementOpener
    {
        List<DrawnItemsInformation> drawnItemsInfoList;
        private string selectedNation;
        private List<IItem> itemList;
        private Graphics graphics;
        private Pen pen;

        public VillageItemsOpener(List<IItem> itemList, string selectedNation, Graphics graphics, Pen pen)
        {
            this.itemList = itemList;
            this.selectedNation = selectedNation;
            this.graphics = graphics;
            this.pen = pen;
        }

        public void displayElements()
        {
            
        }
    }
}
