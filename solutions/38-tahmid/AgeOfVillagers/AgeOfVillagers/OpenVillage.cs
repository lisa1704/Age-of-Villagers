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

        public OpenVillage(IGames game, Label villageNameLabel, string selectedNation)
        {
            this.game = game;
            this.villageNameLabel = villageNameLabel;
            this.selectedNation = selectedNation;
        }

        public void execute()
        {
            
        }
    }
}
