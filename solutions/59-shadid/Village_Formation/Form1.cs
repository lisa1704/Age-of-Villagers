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
            int x = e.X;
            int y = e.Y;
            if (radioButton1.Checked)
            {
                g.DrawLine(mypen, x, y, x + 24, y+16);
                g.DrawLine(mypen, x + 24, y+16, x +29, y +18);
                g.DrawLine(mypen, x +29, y + 18, x+34, y - 16);
                g.DrawLine(mypen, x + 34, y - 16, x+41, y-13);
                g.DrawLine(mypen, x + 41, y - 13,x+51,y-17);




            }
            else if(radioButton2.Checked)
            {
               
                g.DrawRectangle(mypen, x, y, 16, 16);
                g.DrawLine(mypen, x, y, x + 8, y - 8);
                g.DrawLine(mypen, x + 8, y - 8, x +16, y);

            }
            else if(radioButton3.Checked)
            {
                g.DrawLine(mypen, x, y, x + 16, y);
                g.DrawLine(mypen, x + 16, y, x + 16, y - 24);
                g.DrawLine(mypen, x + 16, y - 24, x , y - 24);
                g.DrawLine(mypen, x , y - 24, x , y );
                g.DrawArc(mypen,x +2 ,y-30 , 25, 25, 0, 360);

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
    }
}
