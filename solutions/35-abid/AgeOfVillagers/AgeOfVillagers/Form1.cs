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
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Click(object sender, EventArgs e)
        {

        }

        private void VillageName_Click(object sender, EventArgs e)
        {
            if (VillageName.Text.Trim() != "" || VillageName.Text != null)

            {

                VillageName.Text = "";

            }
        }

        private void Nations_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {

        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }

        private void formRefresh()
        {
            VillageName.Text = "Enter Village Name";
            Nations.SelectedIndex = -1;
            House.Checked = false;
            Tree.Checked = false;
            WaterSource.Checked = false;
            this.Invalidate();
        }
    }
}
