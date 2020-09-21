using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Age_of_Villagers.Age_of_Villagers;

namespace Age_of_Villagers
{
    public partial class Village : Form
    {
        string ItemNames ;
        string village_name ;
        string village_type ;
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();
        Factory_Nation nationfactory = new Factory_Nation();
        public Village()
        {
            InitializeComponent();
        }


        private void NationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            village_type = NationName.Text;
            drawingPanel.BackColor = nationfactory.GetNation(village_type).BackgroundColor();
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
            if (treeButton.Checked == true)
            {
                ItemNames = "Tree";
                Console.WriteLine(ItemNames);
            }      
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (houseButton.Checked == true)
            {
                ItemNames = "House";
                Console.WriteLine(ItemNames);
            }
        }

        private void waterSourceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (waterSourceButton.Checked == true)
            {
                ItemNames = "Water Source";
                Console.WriteLine(ItemNames);
            }
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
            NationName.Text = "Select Nation";
            drawingPanel.BackColor = nationfactory.GetNation(village_type).BackgroundColor();
            MessageBox.Show("Panel is ready for new village to be created");
        }

        private void openVillagebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village is opened");
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawingPanel.CreateGraphics();

            foreach (Point point in tree_point)
            {
                nationfactory.GetNation(village_type).DrawTree(g, point);
            }

            foreach (Point point in house_point)
            {
                nationfactory.GetNation(village_type).DrawHouse(g, point);
            }

            foreach (Point point in waterSource_point)
            {
                nationfactory.GetNation(village_type).DrawWaterSource(g, point);
            }

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

    }
}
