using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public partial class VillageEditorWindow : Form
    {
        string name;
     
        public VillageEditorWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = villNameBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
/*
        private void house_Click(object sender, EventArgs e)
        {
            text = "House";

        }

        

    */

        
       

        

        private void saveVill_Click(object sender, EventArgs e)
        {
            MessageBox.Show(villNameBox.Text + " Village saved");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            


        }

        private void newVill_Click(object sender, EventArgs e)
        {
            newVill nv= new newVill();
            nv.Show();
            this.Hide();
        }
        
        private void rdButtonHouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
