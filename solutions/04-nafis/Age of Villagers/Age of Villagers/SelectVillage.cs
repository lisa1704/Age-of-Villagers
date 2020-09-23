using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class SelectVillage : Form
    {

        private readonly VillageWindow villageWindow;
        private readonly Graphics graphics;
        private readonly Pen pen;
        private readonly Panel panel;
        private readonly VillageCondition villageCondition;

        public SelectVillage(VillageWindow villageWindow, Graphics graphics, Pen pen, Panel panel, VillageCondition villageCondition)
        {
            this.villageWindow = villageWindow;
            this.graphics = graphics;
            this.pen = pen;
            this.villageCondition = villageCondition;
            this.panel = panel;
            
        }

        public SelectVillage(VillageWindow villageWindow, Panel panel)
        {
            
        }

        private void SelectNationButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NationNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectVillage_Load(object sender, EventArgs e)
        {

        }
    }
}
