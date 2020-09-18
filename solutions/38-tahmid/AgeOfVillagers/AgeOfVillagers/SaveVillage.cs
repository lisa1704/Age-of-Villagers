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
        private List<IItem> itemList;

        public SaveVillage(IGames game, string sVillageName, List<IItem> itemList)
        {
            this.game = game;
            this.sVillageName = sVillageName;
            this.itemList = itemList;
        }

        public void execute()
        {
            game.saveVillage(itemList, sVillageName);
        }
    }
}
