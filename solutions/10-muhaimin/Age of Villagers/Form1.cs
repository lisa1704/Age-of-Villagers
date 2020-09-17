using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        Graphics g;
        String text = "";
        Village myVillage = new Village();
        VillageSerializer myVS = new VillageSerializer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myVS.saveState(myVillage);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);
            Font fy = new Font("Helvetica", 10, FontStyle.Bold);
            Brush br = new SolidBrush(System.Drawing.Color.Black);
            g.DrawString(text, fy, br, new Point(x, y));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            refreshForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;
            panel1.Invalidate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            text = "House";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            text = "Water";
        }
        private void refreshForm()
        {
            comboBox1.Text = "Village Name";
            Nation.Text = "Nation Name";
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            this.Invalidate();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
