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

        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> watersource_point = new List<Point>();
        INation n;
        NationFactory nationFactory = new NationFactory();

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

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
            vName = VillageName.Text;
        }

        private void mouseClick1_drawingPanel(object sender, MouseEventArgs e)
        {

           if(s == "Tree")
           {
                tree_point.Add(e.Location);
           }
           if (s == "House")
           {
                house_point.Add(e.Location);
           }
           if (s == "WaterSource")
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
            MessageBox.Show(Text = "Your village has been saved");
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            watersource_point.Clear();
            NationBox.ResetText();
            drawingPanel.Refresh();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }
        private void NationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectNation = NationBox.Text;
            
        }

        private void Tree_MouseClick(object sender, MouseEventArgs e)
        {
            s = "Tree";
        }

        private void House_MouseClick(object sender, MouseEventArgs e)
        {
            s = "WaterSource";
        }

        private void WaterSource_MouseClick(object sender, MouseEventArgs e)
        {
            s = "House";
        }

  
    }
}
