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
    public partial class VillageWindow : Form
    {

        int x;
        int y;
        Graphics g;
        string text = "";
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void House_Click(object sender, EventArgs e)
        {
            text = "House";
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            text = "WaterSource";
        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village is Saved");
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Village is Saved");
        }

        private void NewVbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Village is Saved");
        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
