using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class CreateNewVillageForm : Form
    {
        public CreateNewVillageForm()
        {
            InitializeComponent();
        }

        public static string village_naaam = "";
      
       

        private void submit_Click(object sender, EventArgs e)
        {
            village_naaam = textBox1.Text;
            VillageEditorWindow village_window_object = new VillageEditorWindow();
            village_window_object.Show();
            this.Hide();

        }

    }
}
