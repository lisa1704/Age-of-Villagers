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
    public partial class VillageWindow : Form
    {
        private Panel drawingPanel,toolsPanel;
        public string text;
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void DrawingSpace_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void saveVillage_Button_Click(object sender, EventArgs e)
        {
            text = "save";
        }
        public void newVillage_Button_Click(object sender, EventArgs e)
        {
            text = "new";
        }
        private void openVillage_Button_Click(object sender, EventArgs e)
        {
            text = "open";
        }

=       private void treeRadioButton_Checked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void houseRadioButton_Checked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void waterRadioButton_Checked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
