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
    public partial class CreateNewVillage : Form
    {
        public CreateNewVillage()
        {
            InitializeComponent();
            //Console.WriteLine("Village Created");
        }

        private void NewVillage_Load(object sender, EventArgs e)
        {
            CreateNewVillage village = new CreateNewVillage();
            village.InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            CreateNewVillage village = new CreateNewVillage();
            village.InitializeComponent();
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            ConfirmSaveVillage.ShowDialog();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            DialogResult result = ConfirmOpenVillage.ShowDialog();
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TreeButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WaterSourceButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
