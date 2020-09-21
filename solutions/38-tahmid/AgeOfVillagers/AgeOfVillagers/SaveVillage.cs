using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class SaveVillage : GameControlCommand
    {
        private IGames game;
        private string sVillageName;
        private List<DrawnItemsInformation> drawnItemsInfoList;
        

        public SaveVillage(IGames game, string sVillageName, List<DrawnItemsInformation> drawnItemsInfoList)
        {
            this.game = game;
            this.sVillageName = sVillageName;
            this.drawnItemsInfoList = drawnItemsInfoList;
        }

        public State execute()
        {
            return game.saveVillage(drawnItemsInfoList, sVillageName);
        }

       
    }
}
