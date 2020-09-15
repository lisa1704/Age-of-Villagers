using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    public partial class Form1 : Form

    {
        int x;
        int y;
        string Text = "";
        string Name = "";
        Graphics graphics;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void tree_btn_Click(object sender, EventArgs e)
        {
            Text = "Tree";
        }

        private void house_btn_Click(object sender, EventArgs e)
        {
            Text = "House";
        }

        private void waterSource_btn_Click(object sender, EventArgs e)
        {
            Text = "Water";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void new_btn_Click(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village opened");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
