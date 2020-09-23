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
    public partial class CreateNewVillage : Form
    {
        string SelectedItemName = "";
        string village_name = "";
        string nationName = "";
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();

        Factory_Nation nationfactory = new Factory_Nation();

        Items myItems;
        public CreateNewVillage()
        {
            InitializeComponent();
        }

        public void villageSaveState() //getting the info from form design
        {
            myItems.NationName = NationName.Text;
            myItems.VillageName = VillageNametextBox.Text;
            myItems.Tree = this.tree_point;
            myItems.House = this.house_point;
            myItems.WaterSource = this.waterSource_point;
        }

        private void CreateNewVillage_Load(object sender, EventArgs e)
        {

        }

        private void AgeOfVillagers_Click(object sender, EventArgs e)
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
            SelectedItemName = "Tree";
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectedItemName = "House";
        }

        private void waterSourceButton_CheckedChanged(object sender, EventArgs e)
        {
            SelectedItemName = "WaterSource";
        }

        private void saveVillagebutton_Click(object sender, EventArgs e)
        {
            villageSaveState();
            VillageSaveOpen save_Village = new VillageSaveOpen(myItems);
            save_Village.saveMyVillage();
            MessageBox.Show(villageName.Text + " Village is saved");
        }

        private void newVillagebutton_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            waterSource_point.Clear();
            drawingPanel.Refresh();
            NationName.ResetText();
            VillageNametextBox.ResetText();
            drawingPanel.BackColor = Color.White;

            MessageBox.Show("Panel is ready for new village to be created");
        }

        private void openVillagebutton_Click(object sender, EventArgs e)
        {
            VillageSaveOpen villageOpen = new VillageSaveOpen(myItems);
            villageOpen.openMyVillage();
            myItems = villageOpen.getmyVillage();
            setSavedVillage(myItems);
            drawingPanel.Refresh();
        }

        public void setSavedVillage(Items myitem)
        {
            NationName.Text = myitem.NationName;
            VillageNametextBox.Text = myitem.VillageName;

            foreach (Point point in myitem.House)
            {
                house_point.Add(point);
            }

            foreach (Point point in myitem.Tree)
            {
                tree_point.Add(point);
            }

            foreach (Point point in myitem.WaterSource)
            {
                waterSource_point.Add(point);
            }
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point point in tree_point)
            {
                nationfactory.GetNation(nationName).DrawTree(point).Draw(p, g);
            }

            foreach (Point point in house_point)
            {
                nationfactory.GetNation(nationName).DrawHouse(point).Draw(p, g);
            }

            foreach (Point point in waterSource_point)
            {
                nationfactory.GetNation(nationName).DrawWaterSource(point).Draw(p, g);
            }

        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (SelectedItemName == "Tree")
            {
                tree_point.Add(e.Location);
            }

            if (SelectedItemName == "House")
            {
                house_point.Add(e.Location);
            }
         
            if (SelectedItemName == "WaterSource")
            {
                waterSource_point.Add(e.Location);
            }

            drawingPanel.Invalidate();
        }

        private void NationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationName = NationName.Text;
            drawingPanel.BackColor = nationfactory.GetNation(nationName).BackgroundColor();
        }

        private void VillageNametextBox_TextChanged(object sender, EventArgs e)
        {
            village_name = VillageNametextBox.Text;
            villageName.Text = village_name;
        }
    }
}
