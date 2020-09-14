﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public partial class Form1 : Form
    {
        int x, y,h,w;
        Pen myPen = new Pen(Color.Black);
        Brush myBrush = new SolidBrush(Color.Blue);

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            h = 50;
            w = 75;
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                g.DrawRectangle(myPen, rect);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
