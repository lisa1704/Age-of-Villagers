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
        Pen myPen = new Pen(Color.Green,3);

        public Form1()
        {
            InitializeComponent();
            //this.Width = 600;
            //this.Height = 400;
         
        }
     

      
        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.Width = 600;
            this.Height = 400;
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
            h = 100;
            w = 200;

            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                //action will be occur 
                //g.DrawLine(myPen, shape);
                g.DrawRectangle(myPen, shape);


            }

            if (radioButton2.Checked)
            {
                //action will be occur 
                //g.DrawLine(myPen, 0, 0, 200, 200);
                g.DrawEllipse(myPen, shape);


            }
            if (radioButton3.Checked)
            {
                g.DrawLine(myPen, x, y, h, w);
            }
        }


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             //x = e.X;
             //y = e.Y;
        }




    }
}
