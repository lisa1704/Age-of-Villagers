﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOV
{
    public partial class AgeOfVillagers : Form
    {
        NationFactory typeOfNation = new NationFactory();
        string selectedNation;
        string itemSelected;
        List<Point> housePoint = new List<Point>();
        List<Point> treePoint = new List<Point>();
        List<Point> waterSourcePoint = new List<Point>();

        public AgeOfVillagers()
        {
            InitializeComponent();
        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNation = Nation.Text;
            Canvas.BackColor = typeOfNation.SelectNation(selectedNation).GetColor();
        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {
            if (Tree.Checked == true)
            {
                itemSelected = "tree";
                Console.WriteLine(itemSelected);
            }            
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            if (House.Checked == true)
            {
                itemSelected = "house";
                Console.WriteLine(itemSelected);
            }
        }

        private void WaterSource_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterSource.Checked == true)
            {
                itemSelected = "water source";
                Console.WriteLine(itemSelected);
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (itemSelected == "house")
            {
                housePoint.Add(e.Location);
            }
            if (itemSelected == "tree")
            {
                treePoint.Add(e.Location);
            }
            if(itemSelected=="water source")
            {
                waterSourcePoint.Add(e.Location);
            }           
        }
    }
}
