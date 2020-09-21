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
        private Panel VillageDrawing;
        private readonly VillageWindow primary;
        public ConfirmName(VillageWindow villageWindow,Panel panel)
        {
            InitializeComponent();
            primary = villageWindow;
            VillageDrawing = panel;
        }

        private void SaveName_Load(object sender, EventArgs e)
        {

        }

        private void NationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmVillage_Click(object sender, EventArgs e)
        {
            primary.VillageNameText.Text = VillageNameText.Text;
            primary.NationNameCombo.Text = NationNameCombo.Text;
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
