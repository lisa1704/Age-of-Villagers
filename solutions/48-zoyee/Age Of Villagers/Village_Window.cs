﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public partial class Village_Window : Form
    {
        int x;
        int y;
        Graphics g;
        string text = "";
        string village_name = "";
        string village_type = "";
        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> waterSource_point = new List<Point>();

        FactoryNation nationFactory = new FactoryNation();
        public Village_Window()
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
            village_name = villageName.Text;
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
            text = "WaterSource";
        }

        private void saveVillagebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(villageName.Text + "Village is saved");
        }

        private void newVillagebutton_Click(object sender, EventArgs e)
        {

        }

        private void openVillagebutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(villageName.Text + "Village is Opened.");
            MessageBox.Show("Village is opened");
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point point in tree_point)
            {
                //g.DrawLine(p, point.X, point.Y, 100, 100);
                //nationFactory.GetNation(village_type).Draw_Tree(g, point);
                nationFactory.GetNation(village_type).Draw_Tree(g, point);
            }

            foreach (Point point in house_point)
            {
                //g.DrawLine(p, point.X, point.Y, 100, 100);
                nationFactory.GetNation(village_type).Draw_House(g, point);
            }

            foreach (Point point in waterSource_point)
            {
                //g.DrawLine(p, point.X, point.Y, 100, 100);
                //nationFactory.GetNation(village_type).Draw_WaterSource(g, point);
                nationFactory.GetNation(village_type).Draw_WaterSource(g, point);
            }
        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (text == "Tree")
            {
                tree_point.Add(e.Location);
            }

            if (text == "House")
            {
                house_point.Add(e.Location);
            }

            if (text == "WaterSource")
            {
                waterSource_point.Add(e.Location);
            }

            drawingPanel.Invalidate();

        }
        private void NationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            village_type = NationName.Text;
        }
    }
}