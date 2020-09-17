﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x;
        int y,h ,w;
        Pen myPen = new Pen(Color.Green,2);

        public Form1()
        {
            InitializeComponent();
            //this.Width = 600;
            //this.Height = 400;
         
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save Village");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Village");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Village");
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x =e.X;
            y = e.Y;
            //h = 100;
            //w = 200;

            Graphics g = this.CreateGraphics();
            //Rectangle shape = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                BangladeshiFarmers bdh = new BangladeshiFarmers(g);
                bdh.DrawHouse(e);
                
            }

            if (radioButton2.Checked)
            {
                BangladeshiFarmers bdt = new BangladeshiFarmers(g);
                bdt.DrawTree(e);


                //EgyptianKing ekt = new EgyptianKing(g);
                //ekt.DrawTree(e);

                




            }
            if (radioButton3.Checked)
            {
                //g.DrawLine(myPen, x, y, h, w);

                BangladeshiFarmers bds = new BangladeshiFarmers(g);
                bds.DrawWaterSource(e);

            }
        }


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             //x = e.X;
             //y = e.Y;
        }




    }
}
