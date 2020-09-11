using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class CreateVillage : Command
    {
        public Games pressedKey;
        Panel drawing_panel;
        System.Windows.Forms.Label village_name;
        public CreateVillage(Games pressedKey, Panel drawing_panel, System.Windows.Forms.Label village_name)
        {
            this.pressedKey = pressedKey;
            this.village_name = village_name;
            this.drawing_panel = drawing_panel;
        }

        

        public void execute()
        {
            pressedKey.createVillage(drawing_panel, village_name);
        }
    }
}
