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
        string text;
        public EditorForm()
        {
            InitializeComponent();
        }

        
        

       

        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageNameBox.Text + " Village saved");
        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void EditorForm_Load(object sender, EventArgs e)
        {

        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            name = VillageNameBox.Text;
        }
        public void setVillageName(string name)
        {
            VillageNameBox.Text = name;
            string VillageName = name;
        }
        public void radioButton_Click()
        {
            if (House_btn.Checked)
            {
                rdButton = House_btn.Text;
            }
            else if (Tree_btn.Checked)
            {
                rdButton = Tree_btn.Text;
            }
            else if (Water_btn.Checked)
            {
                rdButton = Water_btn.Text;
            }
            else
                rdButton = "";


        }

        private void Tree_btn_CheckedChanged(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {
            text = "House";
            
        }

        private void Water_btn_CheckedChanged_1(object sender, EventArgs e)
        {
            text = "Water Source";
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            new_btn nv = new new_btn;
            nv.Show();
            this.Hide();
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
