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


        bool button7isClick = false;

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tree");
            button7isClick = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("House");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Water Source");
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


        private void splitter2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Green);
            Brush myBrush = new SolidBrush(Color.Blue);
            g.DrawLine(myPen, 0, 0, 200, 200);

            if (button7isClick) {
                //action will be occur 
            }
            
        }

       
    }
}
