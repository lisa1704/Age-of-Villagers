using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        private String VillageName, NationName;

        public VillageWindow()
        {
            InitializeComponent();
        }


        private void OnClickNewVillage(object sender, EventArgs e)
        {
            NewForm();
        }

        private void OnClickOpenVillage(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickSaveVillage(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickWaterRadioButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickHouseRadioButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnClickTreeRadioButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextNation_TextChanged(object sender, EventArgs e)
        {
            NationName = NationNameText.Text;
        }

        private void TextVillageName_TextChanged(object sender, EventArgs e)
        {
            VillageName = VillageNameText.Text;
        }

        private void NewForm()
        {
            VillageNameText.Text = "Name of the Village";
            NationNameText.Text = "Name of the Nation";
            HouseRadioButton.Checked = false;
            TreeRadioButton.Checked = false;
            WaterRadioButton.Checked = false;
            this.Invalidate();
        }
        
    }
}
