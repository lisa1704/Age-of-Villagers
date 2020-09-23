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
    public partial class VillageEditor : Form
    {

        string s;
        string vName="";
        string selectNation;
        Color villageTerrainColor;

        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> watersource_point = new List<Point>();
        INation n;
        NationFactory nationFactory = new NationFactory();
        VillageItems villageItems;

        public VillageEditor()
        {
            InitializeComponent();

        }

        public void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            foreach (Point point in tree_point)
            {
                nationFactory.GetNation(selectNation).DrawTree(graphics,point);
            }
            foreach (Point point in house_point)
            {
                nationFactory.GetNation(selectNation).DrawHouse(graphics, point);
            }
            foreach (Point point in watersource_point)
            {
                nationFactory.GetNation(selectNation).DrawWaterSource(graphics, point);
            }



        }

        private void VillageEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VillageEditor_Load_1(object sender, EventArgs e)
        {

        }

        public void VillageName_TextChanged(object sender, EventArgs e)
        {
            vName = VillageName.Text;
        }

        public void mouseClick1_drawingPanel(object sender, MouseEventArgs e)
        {

           if(s == "Tree")
           {
                tree_point.Add(e.Location);
           }
           if (s == "House")
           {
                house_point.Add(e.Location);
           }
           if (s == "Water Source")
           {
                watersource_point.Add(e.Location);
           }
            drawingPanel.Invalidate();
        }

        private void mouseClick_NationList(object sender, MouseEventArgs e)
        {

        }

        private void TreeClick(object sender, EventArgs e)
        {
            
        }

        private void WaterSourceClick(object sender, EventArgs e)
        {
            
        }

        private void HouseClick(object sender, EventArgs e)
        {
            
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            SaveVillageState();
            VillageOpenSave saveTheVillage = new VillageOpenSave(villageItems);
            saveTheVillage.SaveVillage();
            MessageBox.Show(vName + "Your village has been saved");
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            watersource_point.Clear();
            NationBox.SelectedIndex=-1;
            drawingPanel.Refresh();
            VillageName.ResetText();
            drawingPanel.BackColor = Color.White;
            MessageBox.Show("Drawing space cleared. You can now create a new village");
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            VillageOpenSave openVillage = new VillageOpenSave(villageItems);
            openVillage.OpenVillage();
            villageItems = openVillage.GetMyVillageItems();
            
        }
        private void NationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectNation = NationBox.Text;
            drawingPanel.BackColor = nationFactory.GetNation(selectNation).SetTerrain();
            villageTerrainColor = drawingPanel.BackColor;
        }

        public void Tree_MouseClick(object sender, MouseEventArgs e)
        {
            s = "Tree";
        }

        public void House_MouseClick(object sender, MouseEventArgs e)
        {
            s = "House";
        }

        public void WaterSource_MouseClick(object sender, MouseEventArgs e)
        {
            s = "Water Source";
        }
        public void SaveVillageState()
        {
            villageItems.nationname = NationBox.Text;
            villageItems.villagename = VillageName.Text;
            villageItems.terraincolor = this.villageTerrainColor;
            villageItems.tp = this.tree_point;
            villageItems.hp = this.house_point;
            villageItems.wsp = this.watersource_point;
        }
        public void SetmySavedVillage(VillageItems vItem)
        {
            NationBox.Text = vItem.nationname;
            VillageName.Text = vItem.villagename;
            villageTerrainColor = vItem.terraincolor;
            foreach(Point point in vItem.tp)
            {
                tree_point.Add(point);
            }
            foreach(Point point in vItem.hp)
            {
                house_point.Add(point);
            }
            foreach(Point point in vItem.wsp)
            {
                watersource_point.Add(point);
            }


        }
  
    }
}
