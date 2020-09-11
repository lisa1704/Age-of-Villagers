using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class NewVillageCreateForm : Form
    {
        public NewVillageCreateForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string villageName = txtboxVillageName.Text;
            string nationName = comboBoxNationName.SelectedItem.ToString();
            AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
            ageOfVillagersForm.setNationName(nationName);
            ageOfVillagersForm.setVillageName(villageName);
            ageOfVillagersForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
            ageOfVillagersForm.Show();
            this.Hide();
        }
    }
}
