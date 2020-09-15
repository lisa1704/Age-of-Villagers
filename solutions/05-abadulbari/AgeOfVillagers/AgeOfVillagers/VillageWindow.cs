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
    public partial class VillageWindow : Form
    {
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void gameLabel_Click(object sender, EventArgs e)
        {

        }

        private void villageLabel_Click(object sender, EventArgs e)
        {

        }

        private void nationLabel_Click(object sender, EventArgs e)
        {

        }

        private void waterRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form f = new CreateNewVillageWindow(this);
            f.Show();
        }
     
        private void houseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void treeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
