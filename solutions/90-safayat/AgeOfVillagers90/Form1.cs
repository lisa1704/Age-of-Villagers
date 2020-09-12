using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers90
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        Graphics g;
        string text = "";
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Saved");
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void House_Click(object sender, EventArgs e)
        {
            text = "House";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            text = "WaterSource";
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village opened");
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {

        }



        private void VillageName_Click(object sender, EventArgs e)
        {

        }

        private void Nation_Click(object sender, EventArgs e)
        {

        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgeofVillagers_Click(object sender, EventArgs e)
        {

        }

        private void DrawingPanel(object sender, MouseEventArgs e)
        {

        }
    }
}
