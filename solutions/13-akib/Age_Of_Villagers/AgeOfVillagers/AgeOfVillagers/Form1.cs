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
        private string text = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = text + "Adding a New Tree...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = text + "Adding a New House...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text = text + "Adding a New Water Resource...";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            text = text + "Saving Your Village...";
        }

        private void NewVillageButton_Click(object sender, EventArgs e)
        {
            text = text + "Creating New Village...";
        }

        private void OpenVillageButton_Click(object sender, EventArgs e)
        {
            text = text + "Opening Your Village...";
        }

        public string getVillageName()
        {
            return VillageName.Text;
        }

        public string getNation()
        {
            return Nation.Text;
        }

        public string getStatus()
        {
            return text;
        }
    }
}
