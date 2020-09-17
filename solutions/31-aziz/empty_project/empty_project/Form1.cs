using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empty_project
{
    public partial class Form1 : Form
    {
        string element_text = "";
        string nation = "";
        List<Point> treePoints = new List<Point>();
        List<Point> housePoints = new List<Point>();
        List<Point> watersourcePoints = new List<Point>();

        SelectNation selectNation = new SelectNation();
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs paint)
        {
            Graphics graphics = DrawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            foreach (Point point in treePoints)
            {
                graphics.DrawLine(pen, point.X, point.Y, 100, 100);
            }

            foreach (Point point in housePoints)
            {
                selectNation.GetNation(nation).DrawHouse(graphics, point);
            }

            foreach (Point point in watersourcePoints)
            {
                graphics.DrawLine(pen, point.X, point.Y, 100, 100);
            }
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Saved");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Tree_Click(object sender, EventArgs e)
        {
            element_text = "Tree";
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Opened");
        }

        private void House_Click(object sender, EventArgs e)
        {
            element_text = "House";
        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            element_text = "Water Source";
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs click)
        {
            if (element_text == "Tree")
            {
                treePoints.Add(click.Location);
            }
            if (element_text == "House")
            {
                housePoints.Add(click.Location);
            }
            if (element_text == "WaterSource")
            {
                watersourcePoints.Add(click.Location);
            }
            DrawingPanel.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
