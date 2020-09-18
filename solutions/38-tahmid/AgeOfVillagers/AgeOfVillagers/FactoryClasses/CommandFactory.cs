using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class CommandFactory
    {
        public GameControlCommand GetCommand(String hint, IGames game, Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName)
        {

            return new CreateVillage(game, drawing_panel, village_name,sVillageName);
        }

        public GameControlCommand CreateCommand(String hint, IGames game, string sVillageName,List<IItem> itemList)
        {

            return new SaveVillage(game, sVillageName, itemList);
        }

    }
}
