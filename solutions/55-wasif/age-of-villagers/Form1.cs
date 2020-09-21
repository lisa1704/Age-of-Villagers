using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace age_of_villagers
{
    public partial class Form1 : Form
    {
        public string village_name;
        public string village_type;
        public string item;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            village_name = textBox2.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            village_type = comboBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            item = "house";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            item = "tree";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gp = panel1.CreateGraphics();
            village_factory new_village = new village_factory(gp, e.Location);
            if (item == "house")
                new_village.get_nation(village_type).draw_house();
            else if (item == "tree")
                new_village.get_nation(village_type).draw_tree();
            else if (item == "water")
                new_village.get_nation(village_type).draw_watersource();
        }
    }
}

