using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        public VillageWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Draw_panel(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Villagename_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void House_Click(object sender, EventArgs e)
        {

        }

        private void Tree_Click(object sender, EventArgs e)
        {

        }

        private void Watersource_Click(object sender, EventArgs e)
        {

        }

        private void Vallagetype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Side_panel(object sender, PaintEventArgs e)
        {

        }

        private void RefreshForm(object sender, EventArgs e)
        {
            foreach (var item in sidepanel.Controls)
                if(item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t = item as TextBox;
                    t.Text = string.Empty;
                }
            villagetype.ResetText();
            villagetype.Text = "Village type";
            drawpanel.Invalidate();
        }
    }
}
