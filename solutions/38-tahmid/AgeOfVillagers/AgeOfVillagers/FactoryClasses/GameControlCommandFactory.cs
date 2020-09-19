using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class GameControlCommandFactory
    {
        public GameControlCommand GetGameControlCommand(String hint, IGames game, Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName)
        {

            return new CreateVillage(game, drawing_panel, village_name,sVillageName);
        }

        public GameControlCommand GetGameControlCommand(String hint, IGames game, string sVillageName,List<IItem> itemList)
        {

            return new SaveVillage(game, sVillageName, itemList);
        }

        public GameControlCommand GetGameControlCommand(String hint, IGames game, Label villageNameLabel, string selectedNation,StateModel previouslySavedState)
        {

            return new OpenVillage(game,villageNameLabel,selectedNation,previouslySavedState);
        }

    }
}
