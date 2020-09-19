using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void execute()
        {
            game.saveVillage(drawnItemsInfoList, sVillageName);
        }
    }
}
