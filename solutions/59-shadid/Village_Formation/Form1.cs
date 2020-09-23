using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Village_Formation
{
    public partial class Form1 : Form
    {

        
        Pen mypen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Draw(object sender, EventArgs e)
        {

        }

        private void DrawWaterResource(object sender, EventArgs e)
        {
           
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            BangladeshiFarmers bd = new BangladeshiFarmers(g);
            EgyptianKings ek = new EgyptianKings(g);
           
            if (radioButton1.Checked)
            {
        
                bd.DrawWaterResource(e);
                ek.DrawWaterResource(e);

            }
            else if(radioButton2.Checked)
            {
                bd.DrawHouse(e);
                ek.DrawHouse(e);
                

            }
            else if(radioButton3.Checked)
            {
                bd.DrawTree(e);
                ek.DrawTree(e);
            }
           
        }

        private void NewVillage(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DrawTree(object sender, EventArgs e)
        {

        }

        private void DrawHouse(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
