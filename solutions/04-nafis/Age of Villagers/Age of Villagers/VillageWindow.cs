using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class VillageWindow : Form
    {
        Graphics graphics;
        Pen pen;
        int x, y = -1;
        bool move = false;

        public VillageWindow()
        {
            InitializeComponent();
            graphics = VillageDrawing.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void VillageDrawing_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GameLabel_Click(object sender, EventArgs e)
        {

        }
        private void VillageNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void HouseRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TreeRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WaterSourceRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveVillageButton_Click(object sender, EventArgs e)
        {
            

        }

        private void NewVillageButton_Click(object sender, EventArgs e)
        {
            Form VillageName = new ConfirmName(this,VillageDrawing);
            VillageName.Show();
            VillageDrawing.Invalidate();
        }

        private void OpenVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void NationNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void VillageDrawing_MouseDown(object sender, EventArgs e)
        {
            move = true;
            /*x = e.X;
            y = e.Y;*/
        }

        private void VillageDrawing_MouseMove(object sender, EventArgs e)
        {
            if (move && x != -1 && y != -1)
            {
                move = true;
                /*x = e.X;
                y = e.Y;*/ 
            }
        }
        private void VillageDrawing_MouseUp(object sender, EventArgs e)
            {
                move = false;
                x = -1;
                y = -1;
            }
        }
}
