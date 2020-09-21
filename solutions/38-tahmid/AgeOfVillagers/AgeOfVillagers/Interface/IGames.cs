using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    interface IGames
    {

        
        public State createVillage(Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName);
        public State saveVillage(State currentState, string villageName);
        public State openVillage(String selectedNation, Label villageName, Graphics graphics, Pen pen);
    }
}
