using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageofvillagers
{
    public partial class Form1 : Form
    {
        private string text = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = text + "Creating New tree...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = text + "create house";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text = text + "water_source";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text = text + "save village ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text = text + "create new village";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Shapecreate nationcreate = village.Get_Nation("current_NationName");
            Shapecreate shape = nationcreate.items("current_selection");
            shape.draw(Cursor.Position.X, Cursor.Position.Y);
        }
    }
}
