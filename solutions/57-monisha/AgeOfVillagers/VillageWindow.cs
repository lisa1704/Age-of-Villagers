using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        Graphics g;
        string VName = "";
        string VType = "";
        string Itemtext = "";
        VillageProperties village;
        public List<Point> HousePoints { get; set; } = new List<Point>();
        public List<Point> TreePoints { get; set; } = new List<Point>();
        public List<Point> WaterPoints { get; set; } = new List<Point>();

        NationFactory nationFactory = new NationFactory();
        public VillageWindow()
        {
            InitializeComponent();
            
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void House_Click(object sender, EventArgs e)
        {
            Itemtext = "House";
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            Itemtext = "Tree";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            Itemtext = "WaterSource";
        }
        public void GetVillageState()
        {
            village.name = VillageNameBox.Text;
            village.House_point = this.HousePoints;
            village.Tree_point = this.TreePoints;
            village.Waterresource_point = this.WaterPoints;            
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {                               
            //Get the current state
            GetVillageState();

            SaveVillage saveVillage = new SaveVillage(village);
            saveVillage.ExecuteAction();
            //MessagBox Show 
            MessageBox.Show(VillageNameBox.Text + " Village saved");
        }
        public void SetVillageState(VillageProperties village)
        {
            VillageNameBox.Text = village.name;
            foreach (Point pt in village.House_point)
            {
                HousePoints.Add(pt);
            }
            foreach (Point pt in village.Tree_point)
            {
                TreePoints.Add(pt);
            }
            foreach (Point pt in village.Waterresource_point)
            {
                WaterPoints.Add(pt);
            }
        }
        private void OpenVillage_Click(object sender, EventArgs e)
        {           
                OpenVillage openVillage = new OpenVillage();
                openVillage.ExecuteAction();
                village = openVillage.GetVillage();
                if (village.name != null )
                {
                    SetVillageState(village);
                    DrawPanel.Refresh();
                }                       
        }

        private void NewVbutton_Click(object sender, EventArgs e)
        {
            VillageNameBox.Clear();
            HousePoints.Clear();
            TreePoints.Clear();
            WaterPoints.Clear();
            NationList.ResetText();
            VType = NationList.Text;
            DrawPanel.BackColor = nationFactory.GetNation(VType).GetTerrainColor();
            DrawPanel.Refresh();
            
        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            VName = VillageNameBox.Text;
            UserVillageName.Text = VName;
        }

        private void NationList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VType = NationList.Text;
            DrawPanel.BackColor = nationFactory.GetNation(VType).GetTerrainColor();
           
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
                nationFactory.GetNation(VType).DrawHouse( g, pt);
            }
            foreach (Point pt in TreePoints)
            {
                nationFactory.GetNation(VType).DrawTree(g, pt);
            }
            foreach (Point pt in WaterPoints)
            {
                nationFactory.GetNation(VType).DrawWaterSource(g, pt);
            }
         
        }

        private void draw_panelMouseClick(object sender, MouseEventArgs e)
        {        
            if (Itemtext == "House")
            {
                HousePoints.Add(e.Location);
            }
            if (Itemtext == "Tree")
            {
                TreePoints.Add(e.Location);
            }
            if (Itemtext == "WaterSource")
            {
                WaterPoints.Add(e.Location);
            }
            DrawPanel.Invalidate();
        }

        private void UserVillageName_Click(object sender, EventArgs e)
        {

        }
    }
}
