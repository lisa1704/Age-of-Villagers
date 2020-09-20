using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class Village : Form
    {
        string ItemNames = "";
        string village_name = "";
        string village_type = "";
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();

        public Village()
        {
            InitializeComponent();
        }

        private void CreateNewVillage_Load(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNames = "Tree";
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNames = "House";
        }

        private void waterSourceButton_CheckedChanged(object sender, EventArgs e)
        {
            ItemNames = "WaterSource";
        }

        private void saveVillagebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(villageName.Text + "Village is saved");
        }

        private void newVillagebutton_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            waterSource_point.Clear();
            drawingPanel.Refresh();
            NationName.ResetText();
            MessageBox.Show("Panel is ready for new village to be created");
        }

        private void openVillagebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village is opened");
        }


        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemNames == "Tree")
            {
                tree_point.Add(e.Location);
            }

            if (ItemNames == "House")
            {
                house_point.Add(e.Location);
            }
         
            if (ItemNames == "WaterSource")
            {
                waterSource_point.Add(e.Location);
            }

            drawingPanel.Invalidate();
        }


        private void VillageNametextBox_TextChanged(object sender, EventArgs e)
        {
            village_name = VillageNametextBox.Text;
            villageName.Text = village_name;
        }

    }
}
