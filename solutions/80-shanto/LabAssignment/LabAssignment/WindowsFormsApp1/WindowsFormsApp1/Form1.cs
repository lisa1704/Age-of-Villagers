using System;
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
            Rectangle shape = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                g.DrawLine(myPen, x, y, x + 50, y);
                g.DrawLine(myPen, x + 50, y, x + 50, y + 25);
                g.DrawLine(myPen, x + 50, y + 25, x, y + 25);
                g.DrawLine(myPen, x, y + 25, x, y);
                g.DrawLine(myPen, x, y, x + 25, y - 25);
                g.DrawLine(myPen, x + 25, y - 25, x + 50, y);


            }

            if (radioButton2.Checked)
            {
                //action will be occur 
                //g.DrawLine(myPen, 0, 0, 200, 200);
                g.DrawArc(myPen, x - 25, y - 25, 50, 50, 0, 360);
                g.DrawLine(myPen, x - 1, y, x + 1, y);
                g.DrawLine(myPen, x + 1, y, x + 1, y + 50);
                g.DrawLine(myPen, x + 1, y + 50, x - 1, y + 50);
                g.DrawLine(myPen, x - 1, y + 50, x - 1, y);


            }
            if (radioButton3.Checked)
            {
                //g.DrawLine(myPen, x, y, h, w);
                g.DrawLine(myPen, x, y, x + 20, y + 16);
                g.DrawLine(myPen, x + 20, y + 16, x + 40, y - 24);
                g.DrawLine(myPen, x + 40, y - 24, x + 8, y - 40);
                g.DrawLine(myPen, x + 8, y - 40, x - 16, y - 24);
                g.DrawLine(myPen, x - 16, y - 24, x - 24, y - 36);
                g.DrawLine(myPen, x - 24, y - 36, x - 36, y - 28);
                g.DrawLine(myPen, x - 36, y - 28, x - 36, y);
                g.DrawLine(myPen, x - 36, y, x - 24, y + 20);
                g.DrawLine(myPen, x - 23, y + 20, x, y);

            }
        }


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             //x = e.X;
             //y = e.Y;
        }




    }
}
