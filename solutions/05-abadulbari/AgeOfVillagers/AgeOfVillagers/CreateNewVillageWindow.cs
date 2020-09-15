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
    public partial class CreateNewVillageWindow : Form
    {
        private VillageWindow vw;

        public CreateNewVillageWindow(VillageWindow vw)
        {
            InitializeComponent();
            this.vw = vw;
        }


        private void CreateVillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            vw.villageLabel.Text = nameBox.Text;
            vw.nationLabel.Text = nationBox.Text;
            this.Dispose();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void nationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
