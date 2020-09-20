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
            newVillage.GetVillage(village_type);
            panel1.Refresh();
        }
    }
}
