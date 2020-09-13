using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //int x;
       // int y;
        string type;
        bool button7isClick = false;
        bool button8isClick = false;
        bool button9isClick = false;
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




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Tree");
            button7isClick = true;
            //type = "tree";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("House");
            button8isClick = true;
            //type = "house";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Water Source");
            button9isClick = true;
            //type = "waterSourse";
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tree");
            button7isClick = true;
            type = "tree";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("House");
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Water Source");
        }



        private void splitter2_Paint(object sender, PaintEventArgs e)
        {
            

            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Green);
            Brush myBrush = new SolidBrush(Color.Blue);
            g.DrawLine(myPen, 0, 0, 200, 200);
            //g.DrawRectangle(myPen, 0, 0, 50, 50);
            //if(button9isClick==true)
            if (button7isClick) {
                //action will be occur 
                //g.DrawLine(myPen, 0, 0, 200, 200);
                g.DrawRectangle(myPen, 0, 0, 50, 50);


            }
            else if (button8isClick==true)
            {
                g.DrawLine(myPen, 0, 0, 200, 200);
                g.DrawRectangle(myPen, 0, 0, 50, 50);
            }

            else if(button9isClick == true) {
                g.DrawLine(myPen, 0, 0, 200, 200);
            }



           

        }

        
    }
}
