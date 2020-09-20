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
    public partial class VillageEditor : Form
    {
        private int x;
        private int y;
        string s;
        string vName="";

        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> watersource_point = new List<Point>();
        INationFactory nationFactory = new NationFactory();
        INation nation = null;

        public VillageEditor()
        {
            InitializeComponent();

        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            foreach (Point point in tree_point)
            {
                ((INationFactory)nationFactory).GetNation(vName).DrawTree(graphics, point);
            }
            foreach (Point point in house_point)
            {
                ((INationFactory)nationFactory).GetNation(vName).DrawHouse(graphics, point);
            }
            foreach (Point point in watersource_point)
            {
                ((INationFactory)nationFactory).GetNation(vName).DrawWaterSource(graphics, point);
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
            
            string selectNation = NationBox.Text;
            MessageBox.Show(selectNation);
            
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
