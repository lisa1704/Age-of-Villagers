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

        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);

            canvas.BackColor = Color.Gainsboro;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Village v = new Village(Text);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e) //tree
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //house
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) //water
        {

        }
        private void button4_Click(object sender, EventArgs e) // Save
        {

        }
        private void button5_Click(object sender, EventArgs e) // New
        {
            canvas.Invalidate();
        }

        private void button6_Click(object sender, EventArgs e) //Open
        {

        }




    }
}
