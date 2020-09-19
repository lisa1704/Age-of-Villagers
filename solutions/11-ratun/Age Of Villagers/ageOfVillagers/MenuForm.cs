using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageOfVillagers
{
    public partial class MenuForm : Form
    {
        String text="";
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ageOfVillagers.save();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //ageOfVillagers.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(VillageName.Text);
        }

        private void Nation_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Nation.Text);
        }

        private void House_Click(object sender, EventArgs e)
        {
            text = "House";
        }

        private void Water_Click(object sender, EventArgs e)
        {
            text = "Water";
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            //ageOfVillagers newVillage = new ageOfVillagers();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            //ageOfVillagers.open(List<Village>);
        }
        public String GetVillageName()
        {
            return VillageName.Text;
        }
    }
}
