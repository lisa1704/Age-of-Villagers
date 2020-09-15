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

        List<Point> treePoints = new List<Point>();
        List<Point> housePoints = new List<Point>();
        List<Point> watersourcePoints = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (element_text == "Tree")
            {
                treePoints.Add(e.Location);
            }
            if (element_text == "House")
            {
                housePoints.Add(e.Location);
            }
            if (element_text == "WaterSource")
            {
                watersourcePoints.Add(e.Location);
            }
        }
    }
}
