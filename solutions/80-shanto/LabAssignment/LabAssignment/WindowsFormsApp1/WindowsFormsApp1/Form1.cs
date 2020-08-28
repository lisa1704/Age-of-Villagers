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
            this.Width = 600;
            this.Height = 400;
         
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Blue);

            //g.DrawLine(myPen, 0, 0, 600, 400);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tree");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("House");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Water Source");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save Village");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Village");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Village");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Bangladeshi Farmers
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //age of villagers
        }

        

        /*private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.Width = 600;
            this.Height = 400;
        }*/
    }
}
