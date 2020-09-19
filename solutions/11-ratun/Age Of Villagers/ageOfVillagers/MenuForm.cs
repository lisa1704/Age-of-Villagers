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
        private String text="";
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(VillageName.Text);
        }

        private void Nation_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Nation.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text += "Adding a tree. ";
        }

        private void House_Click(object sender, EventArgs e)
        {
            text += "Adding a house. ";
        }

        private void Water_Click(object sender, EventArgs e)
        {
            text += "Adding new Water Source. ";
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            text += "Creating the village. ";
            //ageOfVillagers newVillage = new ageOfVillagers();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            text += "Opening the village. ";
            //ageOfVillagers.open(List<Village>);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ageOfVillagers.save();
            text += "Saving the village. ";
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //ageOfVillagers.Load();
            text += "Loading the village. ";

        }

        public String GetVillageName()
        {
            return VillageName.Text;
        }
        public String GetDrawingState()
        {
            return text;
        }
    }
}
