﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    
    public partial class DrawingWindow : Form
    {
        public static string VillageName;
        // private VillageState state;
        // private Village newVillage;
        private List<Point> house_locations { get; set; } = new List<Point>();
        private List<Point> tree_locations { get; set; } = new List<Point>();
        private List<Point> watersource_locations { get; set; } = new List<Point>();
        public DrawingWindow()
        {
            InitializeComponent(); 

        }
        private void DrawingWindow_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.VillageName;
            label3.Text = Form1.NationName;
            Nations nation = new Nations(Form1.NationName, Drawingpanel);
            nation.getNation().PaintTerrain(Drawingpanel);
            
             if (Form1.NationName == "Arab Beduins")
            {
                
                radioButton3.Visible = false;
            }
            
            if (Form1.NationName == "Inuit Hunters")
            {
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            

        }
        

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            
            VillageState state = new VillageState();
            
           
           // VillageStateSaver savevillage = new VillageStateSaver();
           // savevillage.execute();
            
            
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            
            
        }
        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point P = new Point(e.X, e.Y);
            Nations nation = new Nations(Form1.NationName, Drawingpanel);
            VillageState state = new VillageState();

            //Drawingpanel.Invalidate();

            if (radioButton2.Checked == true)
            {
                nation.getNation().DrawHouse(P, Drawingpanel);
                //state.setHouseState(P);

            }
            if (radioButton1.Checked == true)
            {

                nation.getNation().DrawTree(P, Drawingpanel);
                //state.setTreeState(P);

            }
            if (radioButton3.Checked == true)
            {

                nation.getNation().DrawWaterSource(P, Drawingpanel);
                //state.setWsourceState(P);
            }
        }

        
    }
}
