using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class NewVillageForm : Form
    {
        public NewVillageForm()
        {
            InitializeComponent();
        }


        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        

        private void submit_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;

            VillageEditorWindow vill_window = new VillageEditorWindow();
            vill_window.Show();
        }

       
    }
}
