﻿using System;
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
    public partial class CreateNewVillage : Form
    {
        int x;
        int y;
        Graphics g;
        string text = "";
        string village_name = "";
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();
        public CreateNewVillage()
        {
            InitializeComponent();
        }

        private void CreateNewVillage_Load(object sender, EventArgs e)
        {

        }

        private void AgeOfVillagers_Click(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {
            string text1 = villageName.Text;
            village_name = text1;
        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            text = "House";
        }

        private void waterSourceButton_CheckedChanged(object sender, EventArgs e)
        {
            text = "Water Source";
        }

        private void saveVillagebutton_Click(object sender, EventArgs e)
        {

        }

        private void newVillagebutton_Click(object sender, EventArgs e)
        {

        }

        private void openVillagebutton_Click(object sender, EventArgs e)
        {

        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
