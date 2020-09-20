using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class OpenVillageForm : Form
    {
        AgeOfVillagersForm ageOfVillagersForm;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        VillageSave villageSave;
        string filePath;
        string nationName;
        VillageOpen villageOpen = new VillageOpen();
        public OpenVillageForm(AgeOfVillagersForm ageOfVillagersForm, VillageSave villageSave)
        {
            InitializeComponent();
            this.ageOfVillagersForm = ageOfVillagersForm;
            this.villageSave = villageSave;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            nationName = cmboChooseNation.SelectedItem.ToString();
            Village village = villageOpen.openVillage(ageOfVillagersForm, filePath,nationName);
            villageOpen.draw(ageOfVillagersForm, village,nationName);
            ageOfVillagersForm.Show();
            this.Hide();
        }

        private void btnChooseVillage_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open saved file";
            openFileDialog.Filter = "aov files (*.aov)|*.aov";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
            ageOfVillagersForm.Show();
            this.Hide();
        }

        private void openVillageForm_Load(object sender, EventArgs e)
        {
        }
    }
}
