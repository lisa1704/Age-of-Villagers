using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class OpenVillage : GameControlCommand
    {
        private IGames game;
        private Label villageNameLabel;
        private string selectedNation;
        List<IItem> itemList;
        private StateModel previouslySavedState;

        public OpenVillage(IGames game, Label villageNameLabel, string selectedNation, StateModel previouslySavedState)
        {
            this.game = game;
            this.villageNameLabel = villageNameLabel;
            this.selectedNation = selectedNation;
            this.previouslySavedState = previouslySavedState;
        }

        public void execute()
        {
            itemList=game.openVillage(selectedNation, villageNameLabel,previouslySavedState);
        }
    }
}
