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
        int x;
        int y;
        Graphics g;
        string ItemText = "";
        string NameofVillage = "";
        string typeofNation = "";
        public List<Point> HousePoints { get; set; } = new List<Point>();
        public List<Point> TreePoints { get; set; } = new List<Point>();
        public List<Point> WaterSourcePoints { get; set; } = new List<Point>();
        VillageItem VillageItem;
        NationFactory nationfactory = new NationFactory();
        public Form1()
        {
            InitializeComponent();
        }

        public void GetVillageSave() //getting the info from form design
        {
            VillageItem.NameofVillage = VillageNametextBox.Text;
            VillageItem.PointHouse = this.HousePoints;
            VillageItem.PointTree = this.TreePoints;
            VillageItem.PointWaterSource = this.WaterSourcePoints;
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

        private void Tree_Click(object sender, EventArgs e)
        {
            ItemText = "Tree";
        }

        private void House_Click(object sender, EventArgs e)
        {
            ItemText = "House";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            ItemText = "WaterSource";
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village opened");
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
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

        private void Nation_Click(object sender, EventArgs e)
        {
            
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e) //600*400
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
                //g.DrawLine(p, pt.X, pt.Y, 100, 100);
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
            if (ItemText == "House")
            {
                HousePoints.Add(e.Location);
            }
            if (ItemText == "Tree")
            {
                TreePoints.Add(e.Location);
            }
            if (ItemText == "WaterSource")
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
