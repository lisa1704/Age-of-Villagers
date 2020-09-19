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
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            var nationManager = new NationManager(myNation, new NationFactory(g));

            if(myNation == "Bangladeshi Farmers")
            {
                this.BackColor = Color.FromArgb(70, 209, 0);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if(myNation == "Arab Bedouins")
            {
                this.BackColor = Color.FromArgb(210, 213, 24);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (myNation == "Egyptian Kings")
            {
                this.BackColor = Color.FromArgb(250, 253, 2);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (myNation == "Inuit Hunters")
            {
                this.BackColor = Color.FromArgb(246, 246, 236);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Refresh();
        }
    }
}
