using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class ConfirmName : Form
    {
        private readonly Panel panel;
        private readonly VillageWindow villageWindow;
        private readonly Graphics graphics;
        private readonly Pen pen;
        private readonly VillageCondition villageCondition;

        public ConfirmName(VillageWindow villageWindow,Panel panel)
        {
            InitializeComponent();
            this.villageWindow = villageWindow;
            this.panel = panel;
        }

        private void SaveName_Load(object sender, EventArgs e)
        {

        }

        private void NationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmVillage_Click(object sender, EventArgs e)
        {
            NationController nationController = new NationController(NationNameCombo.Text);
            VillageConditionEdit villageConditionEdit = new VillageConditionEdit(graphics, pen, panel, nationController);

            villageWindow.NationNameCombo.Text = NationNameCombo.Text;
            villageWindow.VillageNameText.Text = villageCondition.name;

            panel.Refresh();
            villageConditionEdit.ResetState(villageCondition, NationNameCombo.Text);
            this.Hide();
        }

        private void VillageNameLabel_Click_(object sender, EventArgs e)
        {

        }

        private void VillageNameText_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetVillageName()
        {
            return VillageNameText.Text;
        }

        public string GetNationName()
        {
            return NationNameCombo.Text;
        }

    }
}
