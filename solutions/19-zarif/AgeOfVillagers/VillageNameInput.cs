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
        private Panel _drawpanel;
        public VillageNameInput(Form1 form1,Panel panel)
        {
            InitializeComponent();
            _parent = form1;
            _drawpanel = panel;
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
            

            NationManager nationManager = new NationManager(comboBox1.Text);

            if (nametextbx.Text.Equals("")|| comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Fil up The Requirements");
            }
            else
            {
                _parent.VillageName.Text = nametextbx.Text;
                _parent.NationName.Text = comboBox1.Text;
                _drawpanel.BackColor = nationManager.getNation(new Point()).GetTerritoryColor();
                this.Hide();

            }
        }
    }
}
