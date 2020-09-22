using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public partial class Form1 : Form
    {
        private EventHandler combobox1_SelectedIndexChanged;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            var nationManager = new NationManager(myNation, new NationFactory(g, this));

            //tree
            if (radioButton1.Checked)
            {
                nationManager.DrawTree(e);
            }
            //house
            if (radioButton2.Checked)
            {
                nationManager.DrawHouse(e);
            }
            //water source
            else if (radioButton3.Checked)
            {
                nationManager.DrawWaterSource(e);
            }
        }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += combobox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Refresh();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            var nationManager = new NationManager(myNation, new NationFactory(g, this));

            nationManager.SetColor();
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
