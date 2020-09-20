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
        Village vill;
        string village_name = "untitled";
        public SaveVillageForm()
        {
            InitializeComponent();
        }

        private void save_villName_Click(object sender, EventArgs e)
        {
            if(textbox_VillageName.Text != "")
            {
                village_name = textbox_VillageName.Text;
            }
            vill.village_name = village_name;
        }

    }
}
