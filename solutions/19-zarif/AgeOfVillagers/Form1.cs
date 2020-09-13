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
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving=false;
        Pen pen;

        public Form1()
        {
            InitializeComponent();

            
          
            g = DrawPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 3);

        }

                     
      
        
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void houseradiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void treeradiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void set_Label(string villagename,string nation)
        {
            VillageName.Text = villagename;
            NationName.Text = nation;

    
        }
        private void WaterRadiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewVillagebtn_Click(object sender, EventArgs e)
        {
            Form vlgname = new VillageNameInput(this);
            DrawPanel.Invalidate();
            vlgname.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Openvillagebtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveVillagebtn_Click(object sender, EventArgs e)
        {
            VillageNameInput vilform = new VillageNameInput(this);
            
           
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }

        }

        

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }
    }
}
