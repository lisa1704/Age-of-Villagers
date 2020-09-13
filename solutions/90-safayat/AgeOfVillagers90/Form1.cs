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
        string name = "";
        string Vtype = "";
        List<Point> HousePoints = new List<Point>();
        List<Point> TreePoints = new List<Point>();
        List<Point> WaterPoints = new List<Point>();


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageName.Text+"Village Saved");
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

        }



        private void VillageName_Click(object sender, EventArgs e)
        {
            name = VillageName.Text;
        }

        private void Nation_Click(object sender, EventArgs e)
        {
            
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
                g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }
            foreach (Point pt in TreePoints)
            {
                g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }
            foreach (Point pt in WaterPoints)
            {
                g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }
        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vtype = NationList.Text;
        }

        private void AgeofVillagers_Click(object sender, EventArgs e)
        {

        }

        private void DrawingPanel(object sender, MouseEventArgs e)
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
                WaterPoints.Add(e.Location);
            }
            DrawPanel.Invalidate();
        }

        private void VillageNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
