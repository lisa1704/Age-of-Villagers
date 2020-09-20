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
        int x, y;
        Graphics g;
        Brush brush = new SolidBrush(Color.Black);
        string text = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Click(object sender, EventArgs e)
        {
            ElementSelect();
        }

        private void VillageName_Click(object sender, EventArgs e)
        {
            if (VillageName.Text.Trim() != "" || VillageName.Text != null)

            {

                VillageName.Text = "";

            }
        }

        private void Nations_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g = DrawingPanel.CreateGraphics();
            g.DrawString(text, Font, brush, new Point(x, y));
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageName.Text + " Saved!");
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Opened!");
        }

        private void formRefresh()
        {
            VillageName.Text = "Enter Village Name";
            Nations.SelectedIndex = -1;
            House.Checked = false;
            Tree.Checked = false;
            WaterSource.Checked = false;
            DrawingPanel.Invalidate();
            text = "";
        }

        private void Nations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ElementSelect()
        {
            if (House.Checked == true && Nations.SelectedIndex > -1)
            {
                text = Nations.SelectedItem + " " + "House";
                brush = new SolidBrush(Color.Brown);
            }
            else if (Tree.Checked == true && Nations.SelectedIndex > -1)
            {
                text = Nations.SelectedItem + " " + "Tree";
                brush = new SolidBrush(Color.Green);
            }
            else if (WaterSource.Checked == true && Nations.SelectedIndex > -1)
            {
                text = Nations.SelectedItem + " " + "Watersrc";
                brush = new SolidBrush(Color.Blue);
            }
        }
    }
}
