﻿using Age_of_Villagers.Models;
using Age_of_Villagers.Models.Manifests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class VillageEditorWindow : Form
    {
        int xAxis;
        int yAxis;
        Point local;
        Boolean HouseSwitch;
        Boolean TreeSwitch;
        Boolean WaterSourceSwitch;

        //
        BangladeshiFarmers farmer = new BangladeshiFarmers();
        
        //

        public VillageEditorWindow()
        {
            InitializeComponent();
        }




        /// Demo
        //BangladeshiFarmers BanglaVillage = new BangladeshiFarmers();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



       
        private void VillageEditorPanel_Click(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            local = p;
            xAxis = p.X;
            yAxis = p.Y;
            VillageEditorPanel.Invalidate();
            VillageEditorPanel.BackColor = Color.Green;
        }
        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {

        }

        private void VillageEditorPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = VillageEditorPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            if (HouseSwitch)
            {
                
                farmer.Draw_House(local, gfx, p);




            }
            if (TreeSwitch)
            {

                farmer.Draw_Tree(local, gfx, p);
                

            }
            if (WaterSourceSwitch)
            {
                farmer.Draw_WaterSource(local, gfx, p);

            }
        }


        private void VillageTitle_Click(object sender, EventArgs e)
        {

        }

        private void NationTitle_Click(object sender, EventArgs e)
        {

        }

        private void WaterSourceButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = false;
            WaterSourceSwitch = true;
            HouseSwitch = false;
        }


        private void TreeButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = true;
            WaterSourceSwitch = false;
            HouseSwitch = false;
        }

        private void HouseButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = false;
            WaterSourceSwitch = false;
            HouseSwitch = true;

        }

        private void NewVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveVillageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
