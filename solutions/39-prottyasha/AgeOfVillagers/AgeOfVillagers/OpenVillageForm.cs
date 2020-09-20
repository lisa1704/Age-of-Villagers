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
        SaveVillageForm svf;
        public OpenVillageForm()
        {
            InitializeComponent();
        }

        private void SavedVillageList_Click(object sender, EventArgs e)
        {
            SavedVillageList.Items.Clear();
            SavedVillageList.Items.Add(svf.savedVillList);
        }
    }
}
