using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private State previouslySavedState;
        private Graphics graphics;
        private Pen pen;

        public OpenVillage(IGames game, Label villageNameLabel, string selectedNation, State previouslySavedState, Graphics graphics, Pen pen)
        {
            this.game = game;
            this.villageNameLabel = villageNameLabel;
            this.selectedNation = selectedNation;
            this.previouslySavedState = previouslySavedState;
            this.graphics = graphics;
            this.pen = pen;
        }

        public void execute()
        {
            itemList=game.openVillage(selectedNation, villageNameLabel,previouslySavedState, graphics, pen);
        }
    }
}
