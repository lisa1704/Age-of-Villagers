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

        private List<Point> PointsOfHouse { get; set; } = new List<Point>();
        private List<Point> PointsOfTree { get; set; } = new List<Point>();
        private List<Point> PointsOfWatersource { get; set; } = new List<Point>();



        public VillageEditorWindow()
        {
            InitializeComponent();
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


        private void PaintDrawPanel(object sender, PaintEventArgs e)
        {
            Graphics gr = drawingpanel.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            foreach (Point j in PointsOfTree)
            {
                nationfactory.GetNation(checked_nation).DrawTree(gr,j);

            }
            foreach (Point j in PointsOfHouse)
            {
                nationfactory.GetNation(checked_nation).DrawHouse(gr,j);

            }
            foreach (Point j in PointsOfWatersource)
            {
                nationfactory.GetNation(checked_nation).DrawWaterSource(gr,j);

            }

        }

        public void drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {

            if (item == "Tree")
            {
                PointsOfTree.Add(e.Location);


            }
            else if (item == "House")
            {
                PointsOfHouse.Add(e.Location);

            }
            else if (item == "Water Source")
            {
                PointsOfWatersource.Add(e.Location);

            }

        }

        public void nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            checked_nation = nation.Text;

        }
        private void villagenameTextChanged(object sender, EventArgs e)
        {
            vname = villagename.Text;
            VillageNamelabel.Text = vname;

        }

        private void savevillage_Click(object sender, EventArgs e)
        {

        }
        public void newvillage_Click(object sender, EventArgs e)
        {
            //drawingpanel.Invalidate();

        }


        public void openvillage_Click(object sender, EventArgs e)
        {
            //drawingpanel.Invalidate();
        }



        


    }
}
