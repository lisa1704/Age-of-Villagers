using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageNameInput : Form
    {
        private readonly Form1 _parent;
        
        public VillageNameInput(Form1 form1)
        {
            InitializeComponent();
            _parent = form1;

        }

        private void VillageNameInput_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public string GetvillageNames()
        {
            return nametextbx.Text;
         }
        public string GetNationeNames()
        {
            return nametextbx.Text;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            _parent.VillageName.Text = nametextbx.Text;
            _parent.NationName.Text = comboBox1.Text;


            this.Hide();
        }
    }
}
