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
        Graphics g;
        string nationType = "";
        string clickedObject;
        List<Point> Houses = new List<Point>();
        List<Point> Trees = new List<Point>();
        List<Point> WaterSourses = new List<Point>();
        FactoryNation Inputnation = new FactoryNation();
        public CreateNewVillage()
        {
            InitializeComponent();
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            clickedObject = "Tree";
        }

        private void House_Click(object sender, EventArgs e)
        {
            clickedObject = "House";
        }

        private void Water_Source_Click(object sender, EventArgs e)
        {
            clickedObject = "Water Source";
        }

        private void Select_Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw_Panel.BackColor = Inputnation.NationType(Select_Nation.Text).Color_Terrain();
        }

        private void Village_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Village_Click(object sender, EventArgs e)
        {

        }

        private void New_Village_Click(object sender, EventArgs e)
        {
            Houses.Clear();
            Trees.Clear();
            WaterSourses.Clear();
            Draw_Panel.Refresh();
            Village_Name.Text = "Enter Village Name";

        }

        private void Open_Village_Click(object sender, EventArgs e)
        {

        }

        private void Draw_Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Draw_Panel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point point in Houses)
            {
                nationType = Select_Nation.Text;
                Inputnation.NationType(nationType).Draw_House(g, point);
            }
            foreach (Point point in Trees)
            {
                nationType = Select_Nation.Text;
                Inputnation.NationType(nationType).Draw_Tree(g, point);
            }
            foreach (Point point in WaterSourses)
            {
                nationType = Select_Nation.Text;
                Inputnation.NationType(nationType).Draw_WaterSource(g, point);
            }

        }

       

        private void Draw_Panel_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (clickedObject == "House")
            {
                Houses.Add(e.Location);
            }
            if (clickedObject == "Tree")
            {
                Trees.Add(e.Location);
            }
            if (clickedObject == "Water Sourse")
            {
                WaterSourses.Add(e.Location);
            }
            Draw_Panel.Invalidate();

        }

        private void CreateNewVillage_Load(object sender, EventArgs e)
        {

        }
    }
}
