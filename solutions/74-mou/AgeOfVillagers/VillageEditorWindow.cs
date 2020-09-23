using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageEditorWindow : Form
    {
        public string item = "", checked_nation = "";
        private string vname ="";
        NationFactory nationfactory = new NationFactory();
        Graphics gr;
        private ItemsOfVillage SVitem;

        //Pen pen;
        private List<Point> PointsOfHouse { get; set; } = new List<Point>();
        private List<Point> PointsOfTree { get; set; } = new List<Point>();
        private List<Point> PointsOfWatersource { get; set; } = new List<Point>();
        


        public VillageEditorWindow()
        {
            InitializeComponent();
           gr = drawingpanel.CreateGraphics();
            
        }
        private void VillageWindow_Load(object sender, EventArgs e) 
        {
        
        }
        private void toolpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void titlelabel_Click(object sender, EventArgs e) 
        {
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savevillage_Click(object sender, EventArgs e)
        {
            GetSavedVillage();
            ConSavingVillage savingvillage = new ConSavingVillage(SVitem);
            savingvillage.ExecuteCommand();
            MessageBox.Show(vname + " village saved!");

        }
        public void GetSavedVillage()
        {
            SVitem.SVillageName = villagename.Text;
            SVitem.SPointsOfTree = this.PointsOfTree;
            SVitem.SPointsOfHouse = this.PointsOfHouse;
            SVitem.SPointsOfWatersource = this.PointsOfWatersource;
        }

        public void SetSavedVillage(ItemsOfVillage vitem)
        {
            villagename.Text = vitem.SVillageName;
            foreach (Point p in vitem.SPointsOfHouse)
            {
                PointsOfHouse.Add(p);
            }
            foreach (Point p in vitem.SPointsOfTree)
            {
                PointsOfTree.Add(p);
            }
            foreach (Point p in vitem.SPointsOfHouse)
            {
                PointsOfWatersource.Add(p);
            }

        }
        private void TreeRadio_CheckedChanged(object sender, EventArgs e)
        {
            item = "Tree";
        }

        private void HouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            item = "House";
        }

        private void WAtersourceRadioCheckedChanged(object sender, EventArgs e)
        {
            item = "Water Source";
        }

        public void openvillage_Click(object sender, EventArgs e)
        {
            ConOpeningVillage openingvillage = new ConOpeningVillage();
            openingvillage.ExecuteCommand();
            SVitem = openingvillage.GetSavedItemsOfVillage();

            if (SVitem.SVillageName != null)
            {
                SetSavedVillage(SVitem);
                drawingpanel.Refresh();
            }

        }

        private void PaintDrawPanel(object sender, PaintEventArgs e)
        {
            foreach (Point p in PointsOfTree)
            {
                nationfactory.GetNation(checked_nation).DrawTree(gr, p);
            }
            foreach (Point p in PointsOfHouse)
            {
                nationfactory.GetNation(checked_nation).DrawHouse(gr, p);
            }
            foreach (Point p in PointsOfWatersource)
            {
                nationfactory.GetNation(checked_nation).DrawWaterSource(gr, p);
            }


        }

        public void drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            //gr.DrawLine(pen, new Point(e.X,e.Y), new Point(e.X + 10, e.Y));
              
            if (item == "Tree")
            {
                nationfactory.GetNation(checked_nation).DrawTree(gr, new Point(e.X, e.Y)).DrawShapes(gr,pen);


            }
            else if (item == "House")
            {
                nationfactory.GetNation(checked_nation).DrawHouse(gr, new Point(e.X, e.Y)).DrawShapes(gr, pen);

            }
            else if (item == "Water Source")
            {
                nationfactory.GetNation(checked_nation).DrawWaterSource(gr, new Point(e.X, e.Y)).DrawShapes(gr, pen);

            }
            

        }
        private void NationTypelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checked_nation = NationTypelistBox.Text;
            drawingpanel.BackColor = nationfactory.GetNation(checked_nation).TerrainColor();
        }
        private void villagenameTextChanged(object sender, EventArgs e)
        {
            vname = villagename.Text;

        }

        
        public void newvillage_Click(object sender, EventArgs e)
        {
            villagename.Clear();
            PointsOfTree.Clear();
            PointsOfHouse.Clear();
            PointsOfWatersource.Clear();
            drawingpanel.Refresh();

        }




        


    }
}
