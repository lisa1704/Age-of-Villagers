using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers90
{
    public partial class Form1 : Form
    {
        string NameofItem = "";
        string NameofVillage = "";
        string typeofNation = "";
        public List<Point> HousePoints { get; set; } = new List<Point>();
        public List<Point> TreePoints { get; set; } = new List<Point>();
        public List<Point> WaterSourcePoints { get; set; } = new List<Point>();

        VillageItem VillageItem;

        readonly NationFactory nationfactory = new NationFactory();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            GetVillageSave();

            VillageSave vs = new VillageSave(VillageItem);
            vs.execute();
            MessageBox.Show(VillageName.Text +" Village Saved");
        }

        public void GetVillageSave() //getting the info from form design
        {
            VillageItem.NameofVillage = VillageNametextBox.Text;
            VillageItem.PointHouse = this.HousePoints;
            VillageItem.PointTree = this.TreePoints;
            VillageItem.PointWaterSource = this.WaterSourcePoints;
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            NameofItem = "Tree";
        }

        private void House_Click(object sender, EventArgs e)
        {
            NameofItem = "House";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            NameofItem = "WaterSource";
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            VillageOpen villageOpen = new VillageOpen();
            villageOpen.execute();
            VillageItem = villageOpen.GetSavedVillage();
            if(VillageItem.NameofVillage != null)
            {
                SetSavedVillage(VillageItem);
                DrawPanel.Refresh();
            }  
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            VillageNametextBox.Clear();
            HousePoints.Clear();
            TreePoints.Clear();
            WaterSourcePoints.Clear();
            DrawPanel.Refresh();
            NationList.ResetText();
            typeofNation = NationList.Text;
            DrawPanel.BackColor = nationfactory.GetNation(typeofNation).BackGroundColor();
        }

        private void VillageName_Click(object sender, EventArgs e) //show
        {
            
        }

        public void SetSavedVillage(VillageItem villageItem)
        {
            VillageNametextBox.Text = villageItem.NameofVillage;
            foreach(Point point in villageItem.PointHouse)
            {
                HousePoints.Add(point);
            }

            foreach (Point point in villageItem.PointTree)
            {
                TreePoints.Add(point);
            }

            foreach (Point point in villageItem.PointWaterSource)
            {
                WaterSourcePoints.Add(point);
            }
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e) 
        {
            Graphics g = DrawPanel.CreateGraphics();
            foreach (Point pt in HousePoints)
            {
                nationfactory.GetNation(typeofNation).DrawHouse(g, pt);

            }
            foreach (Point pt in TreePoints)
            {
                nationfactory.GetNation(typeofNation).DrawTree(g, pt);
            }
            foreach (Point pt in WaterSourcePoints)
            {
                nationfactory.GetNation(typeofNation).DrawWaterSource(g, pt);
            }
        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeofNation = NationList.Text;
            DrawPanel.BackColor = nationfactory.GetNation(typeofNation).BackGroundColor();
        }

        private void AgeofVillagers_Click(object sender, EventArgs e)
        {

        }

        private void DrawingPanel(object sender, MouseEventArgs e) // mouse
        {
            if (NameofItem == "House")
            {
                HousePoints.Add(e.Location);
            }
            if (NameofItem == "Tree")
            {
                TreePoints.Add(e.Location);
            }
            if (NameofItem == "WaterSource")
            {
                WaterSourcePoints.Add(e.Location);
            }
            DrawPanel.Invalidate();
        }

        private void VillageNametextBox_TextChanged(object sender, EventArgs e) //input
        {
            NameofVillage = VillageNametextBox.Text;
            VillageName.Text = NameofVillage;
        }
    }
}
