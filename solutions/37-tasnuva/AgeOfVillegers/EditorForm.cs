using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillegers
{
    
    public partial class EditorForm : Form
    {
        string VillageName;
        string name;
        string nation;
        public EditorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            name = VillageNameBox.Text;



        }
        public void setVillageName(string name)
        {
            VillageNameBox.Text = name;
            string VillageName = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
