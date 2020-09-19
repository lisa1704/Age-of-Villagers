using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class Form1 : Form
    {
        string name;
        string nation;
        string VillageType;
        string text;
        public Form1()
        {
            InitializeComponent();
        }

        private void VillageBox_TextChanged(object sender, EventArgs e)
        {
            name = villageNameBox.Text;
        }
        public void setVillageName(string Name)
        {
            villageNameBox.Text = Name;
            string villageName = Name;

        }

        private void Tree_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;

        }

        private void Water_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageNameBox.Text + " Village saved");
        }

        private void New_btn_Click(object sender, EventArgs e)
        {

        }

        private void Open_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
