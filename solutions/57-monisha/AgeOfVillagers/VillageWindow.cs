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
    public partial class VillageWindow : Form
    {

        int x;
        int y;
        Graphics g;
        string name = "";
        string VType = "";
        string Itemtext = "";
        List<Point> HousePoints = new List<Point>();
        List<Point> TreePoints = new List<Point>();
        List<Point> WaterPoints = new List<Point>();

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

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageNameBox.Text+"Village saved");
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Village is Saved");
        }

        private void NewVbutton_Click(object sender, EventArgs e)
        {
          
            //MessageBox.Show("Village is Saved");
        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            name = VillageNameBox.Text;
            
        }

        private void NationList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VType = NationList.Text;
            Color NName = nationFactory.GetNation(VType).GetTerrainColor();
            DrawPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            /*nation = nationFactory(NationList.Text);
            g.Clear(Color.White);
            drawingSpace.BackColor = nation.SetBackground();*/
            //string NName =nationFactory.GetNation(VType).DrawHouse();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
           //Drawing.BackColor = Color.LightBlue;
            Graphics g = DrawPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
                //g.DrawLine(p, pt.X, pt.Y , pt.X+16, pt.X + 16);
                nationFactory.GetNation(VType).DrawHouse( g, pt);
            }
            foreach (Point pt in TreePoints)
            {
                nationFactory.GetNation(VType).DrawTree(g, pt);
                //g.DrawLine(p, pt.X, pt.Y , pt.X +16, pt.X +24);
            }
            foreach (Point pt in WaterPoints)
            {
                nationFactory.GetNation(VType).DrawWaterSource(g, pt);
                //g.DrawLine(p, pt.X, pt.Y, 100, 100);
            }
         
        }

        private void draw_panelMouseClick(object sender, MouseEventArgs e)
        {
            /* Point p = new Point(e.X, e.Y);
             x = p.X;
             y = p.Y;
             DrawPanel.Invalidate();*/
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
    }
}
