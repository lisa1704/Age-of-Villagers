using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class CommandFactory
    {
        public GameControlCommand CreateCommand(String hint, IGames pressedKey, Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName)
        {

            return new CreateVillage(pressedKey, drawing_panel, village_name,sVillageName);
        }

        
    }
}
