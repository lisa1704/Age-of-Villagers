using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class CommandFactory
    {
        public Command CreateCommand(String hint, Games pressedKey, Panel drawing_panel, System.Windows.Forms.Label village_name)
        {

            return new CreateVillage(pressedKey, drawing_panel, village_name);
        }
    }
}
