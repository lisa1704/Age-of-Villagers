using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class SaveVillageForm : Form
    {
        string village_name = "untitled";
        public SaveVillageForm()
        {
            InitializeComponent();
        }

        private void textbox_VillageName_TextChanged(object sender, EventArgs e)
        { 
        }

        private void save_villName_Click(object sender, EventArgs e)
        {
            if(textbox_VillageName.Text != "")
            {
                village_name = textbox_VillageName.Text;
            }
        }
    }
}
