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
        int x;
        int y;

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
            BangladeshiFarmers v = new BangladeshiFarmers();
            v.DrawHouse(g);

            canvas.BackColor = v.terrainColor();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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

        private void canvas_Click(object sender, EventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;
            panel1.Invalidate();
        }
    }
}
